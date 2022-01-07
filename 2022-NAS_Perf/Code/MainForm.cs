/*
 * BACKGROUND
  * The source code of a NAS performance tester is published here:
 * http://www.808.dk/?code-csharp-nas-performance
 * which is a personal web site by Ulrik D. Hansen 
 * It's publishe under: Some rights reserved (CC by 3.0) 
 * https://creativecommons.org/licenses/by/3.0/
 * 
 * This project adopted the concept for VS2017 and Dot Net 4.5.2 or later
 * similar to how https://github.com/AndMu/NASPerformanceTester did it
 * the code now uses the await and async statements which is explained here:
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
 * 
 * 
 * 
 * CODE CONVENTIONS
 * pascal casing:             FirstName       (aka "UpperCamelCase")
 * camel casing":             firstName       (aka lowerCamelCase)
 * _-prefix:                 _firstName
 * 
 * 
 * When naming classes and public members 
 * (of types, such as fields, properties, events, methods, and local functions)
 * use PascalCasing             e.g. public void StartEventProcessing()
 * 
 * When naming private methods, parameters and local variables 
 * use lowerCamelCasing         e.g private string[] getNetworkDriveLetters()
 * 
 * 
 * When naming private members, except methods, 
 * prefix with _                e.g. private bool _loopBreak;
 * 
 * More about code conventions are found here: 
 * https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
 * https://en.wikipedia.org/wiki/Naming_convention_(programming)#C#
 
 * CONTROLS NAMING CONVENTIONS e.g. in MainForm.Designer.cs
 * TextBox nameText;            // the control used to edit the name
 * Label nameLabel;             // the control used to label the edit control
 * Button setDefaultButton;     // the control that resets the name to a default value.
 * ComboBox driveLetterCombo;   // a ComboBox populated with drive letters at start up
 * 
 * 
 * 
 * 
*/



using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASPerformanceTester
{
    public partial class MainForm : Form
    {
        private string localStoragePath;
        private bool _loopBreak;
        private ulong _testFileSize;
        private bool _testIsActive;
        private ulong _testIterations;
        private string _testPath;
        private string _testType;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            OutputText("\r\n");
            SetDefaults();
            driveLetterCombo.Items.AddRange(getNetworkDriveLetters());
            if (getNetworkDriveLetters().Length > 0)
            {
                driveLetterCombo.SelectedIndex = 0;
            }

            ActiveControl = networkPath;
            if (IsFolderWritable(Path.GetDirectoryName(Application.ExecutablePath)))
            {
                localStoragePath = Path.GetDirectoryName(Application.ExecutablePath);
            }
            else // Write access to program folder denied, falling back to Windows temp folder as defined in the environment variables
            {
                localStoragePath = Path.GetTempPath();
            }

            base.OnLoad(e);
        }

        public void SetDefaults()
        {
            loopsCombo.SelectedIndex = 1;
            fileSizeCombo.SelectedIndex = 2;
            networkPath.Text = "C:\\temp";

        }





        private async void benchmarkHandler()
        
        {
            string fileSize, loops;

            _testIsActive = true;
            _loopBreak = false;
            benchmarkButton.Text = "Stop";
            // if path is emty, use a drive leter
            if (string.IsNullOrEmpty(networkPath.Text))
            {
                _testPath = driveLetterCombo.Text + ":";
            }
            else
            {
                _testPath = networkPath.Text;
            }
            //await Task.Run(() => benchmarkAsync("100","3"));
            fileSize = fileSizeCombo.Text;
            loops = loopsCombo.Text;
            await Task.Run(() => benchmarkAsync(fileSize, loops));
            _testIsActive = false;
            _loopBreak = false;
            benchmarkButton.Text = "Start";
        }

        private void benchmarkAsync(string testFS, string testIter )
        {


            if (!_loopBreak)
            {
                // Run warmup
                _testFileSize = 0; // for warmup run
                _testIterations = 1;
                _testType = "write";
                TestPerf();
            }

            //testFileSize = Convert.ToUInt64(fileSize.Text) * 1000000; //B2 not thread safe?
            //testFileSize = Convert.ToUInt64("100") * 1000000;
            _testFileSize = Convert.ToUInt64(testFS) * 1000000;

            //testIterations = Convert.ToUInt64(loops.Text); //B2 not thread safe?
            //testIterations = Convert.ToUInt64("3");
            _testIterations = Convert.ToUInt64(testIter);

            if (!_loopBreak)
            {
                // Run write test
                _testType = "write";
                TestPerf();
            }

            if (!_loopBreak)
            {
                // Run read test
                _testType = "read";
                TestPerf();
            }
        }

        private string[] getNetworkDriveLetters()
        {
            ArrayList networkDriveLetters = new ArrayList();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType == DriveType.Network)
                {
                    networkDriveLetters.Add(d.Name.Substring(0, 1));
                }
            }

            return networkDriveLetters.ToArray(typeof(string)) as string[];
        }

        private bool IsFolderWritable(string folderPath)
        {
            try
            {
                using (FileStream fs = File.Create(Path.Combine(folderPath, Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose))
                {
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

    
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void TestPerf()
        {
            try
            {
                string firstPath;
                string secondPath;
                string shortType;
                string iterText;
                ulong appendIterations;
                double totalPerf;
                DateTime startTime;
                DateTime stopTime;
                string randomText = RandomString(100000);
                if (_testType == "read")
                {
                    firstPath = _testPath;
                    secondPath = localStoragePath;
                    shortType = "R";
                }
                else
                {
                    firstPath = localStoragePath;
                    secondPath = _testPath;
                    shortType = "W";
                }
                if (_testIterations == 1)
                {
                    iterText = "once";
                }
                else if (_testIterations == 2)
                {
                    iterText = "twice";
                }
                else
                {
                    iterText = _testIterations + " times";
                }
                if (_testFileSize == 0)
                {
                    OutputText("Running warmup...\r\n");
                    appendIterations = 100; // equals a 10MB warmup file.
                }
                else
                {
                    OutputText(
                        "Running a " + _testFileSize / 1000000 + " MB file " + _testType +
                        " on " + _testPath + " " + iterText + "...\r\n");
                    appendIterations = _testFileSize / 100000;

                    // Note: dividing integers in C# always produce a whole number,
                    // so no explicit rounding or type conversion is needed
                }
                totalPerf = 0;
                for (ulong j = 1; j <= _testIterations; j++)
                {
                    Application.DoEvents();
                    //https://www.codeproject.com/Questions/1057766/How-to-resolve-Cross-thread-operation-not-valid-er
                    // " Any time you end up using Application.DoEvents it normally means there is a real problem with your code"
                    if (File.Exists(firstPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(firstPath + "\\" + j + "test.tmp");
                    }
                    if (File.Exists(secondPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(secondPath + "\\" + j + "test.tmp");
                    }
                    if (_loopBreak)
                    {
                        OutputText("Benchmark cancelled.\r\n");
                        break;
                    }
                    StreamWriter sWriter = new StreamWriter(
                        firstPath +
                        "\\" + j + "test.tmp",
                        true,
                        Encoding.UTF8,
                        1048576);
                    for (ulong i = 1; i <= appendIterations; i++)
                    {
                        sWriter.Write(randomText);
                    }
                    sWriter.Close();
                    startTime = DateTime.Now;
                    File.Copy(
                        firstPath + "\\" + j + "test.tmp",
                        secondPath + "\\" + j + "test.tmp");
                    stopTime = DateTime.Now;
                    File.Delete(firstPath + "\\" + j + "test.tmp");
                    File.Delete(secondPath + "\\" + j + "test.tmp");
                    TimeSpan interval = stopTime - startTime;
                    if (_testIterations > 1)
                    {
                        OutputText(
                            ("Iteration " + j + ":").PadRight(15) +
                            (_testFileSize / 1000 / interval.TotalMilliseconds).ToString("F2").PadLeft(7) +
                            " MB/sec\r\n");
                    }

                    totalPerf += _testFileSize / 1000 / interval.TotalMilliseconds;
                }

                if (_testFileSize != 0 && _loopBreak == false)
                {
                    OutputText("-----------------------------\r\n");
                    OutputText(
                        "Average (" + shortType + "):" +
                        (totalPerf / _testIterations).ToString("F2").PadLeft(10) + " MB/sec\r\n");
                    OutputText("-----------------------------\r\n");
                }
            }
            catch (Exception e)
            {
                OutputText("An error occured: " + e.Message + "\r\n");
            }
        }

        private void OutputText(string text)
        {
            this.Execute(
                () =>
                {
                    resultArea.AppendText(text);
                });
        }

        private void benchmarkButton_Click(object sender, EventArgs e)
        {
            if (!_testIsActive)
            {
                int checkFileSize;
                int checkLoops;
                if ((!string.IsNullOrEmpty(driveLetterCombo.Text) || networkPath.Text.IndexOf("\\\\") == 0 && networkPath.Text.IndexOf("\\", 2) > 2) &&
                    int.TryParse(fileSizeCombo.Text, out checkFileSize) &&
                    int.TryParse(loopsCombo.Text, out checkLoops))
                {
                    if (checkFileSize <= 64000)
                    {
                        benchmarkHandler();
                    }
                    else
                    {
                        OutputText("The maximum test file size is 64GB.\r\n");
                    }
                }
                else
                {
                    OutputText("Input invalid. Check drive letter or network path, file size and loops.\r\n");
                }
            }
            else
            {
                _loopBreak = true;
                OutputText("Cancelling. Please wait for current loop to finish...\r\n");
            }
        }

        private void urlLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            Process.Start(target);
        }

        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            SetDefaults();

        }

        private void resultArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
