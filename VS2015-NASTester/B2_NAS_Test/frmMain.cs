using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        private bool loopBreak = false;
        private string testPath;
        private ulong testFileSize;
        private ulong testIterations;
        private string testType;
        private string localStoragePath;
        private Thread workerThread;
        private bool testIsActive = false;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // frmMain. = "B2_NAS_Test";
           Text = "B2_NAS_Test";
            
            //resultArea.Location = new Point(5, 30);
            //resultArea.Size = new Size(533, 305);
            resultArea.ReadOnly = true;
            resultArea.Multiline = true;
            //resultArea.ScrollBars = ScrollBars.Vertical;
            resultArea.ScrollBars = ScrollBars.Both;
            resultArea.WordWrap = false;
            resultArea.Text = "B2 NAS performance tester 0.1 \r\n";
            resultArea.Font = new Font("Courier New", 8);
            
        }




        private void btnMeasure_Click(object sender, EventArgs e)
        {
            

            
        if (!testIsActive)
        {
            int checkFileSize;
            int checkLoops;
             //if ((!String.IsNullOrEmpty(driveLetter.Text) || (networkPath.Text.IndexOf("\\\\") == 0 && networkPath.Text.IndexOf("\\", 2) > 2)) &&
             if (int.TryParse(cbFileSize.Text, out checkFileSize) &&
                int.TryParse(cbLoops.Text, out checkLoops))
            {
                if (checkFileSize <= 64000)
                {
                        //Thread newThread = new Thread(new ThreadStart(BenchmarkHandler));
                        Thread newThread = new Thread(new ThreadStart(BenchmarkHandler));
                        newThread.Start();
                }
                else
                {
                    resultArea.AppendText("The maximum test file size is 64GB.\r\n");
                    resultArea.Invalidate();
                }
            }
            else
            {
                resultArea.AppendText("Input invalid. Check drive letter or network path, file size and loops.\r\n");
                resultArea.Invalidate();
            }
        }
        else
        {
            loopBreak = true;
            resultArea.AppendText("Cancelling. Please wait for current loop to finish...\r\n");
            resultArea.Invalidate();
        }
            




        }

        private void BenchmarkHandler2()
        {
            testIsActive = true;
            loopBreak = false;

            if (!loopBreak)
            { 
                LaunchTestThread();
            }
            testIsActive = false;
            loopBreak = false;

        }

        private void BenchmarkHandler()
        {
            testIsActive = true;
            loopBreak = false;
            //benchmarkButton.Text = "Stop";
            testPath = "c:";
            //if (String.IsNullOrEmpty(networkPath.Text))
            //{
            //    testPath = driveLetter.Text + ":";
            //}
            //else
            //{
            //    testPath = networkPath.Text;
            //}
            if (!loopBreak)
            { // Run warmup
                testFileSize = 0; // for warmup run
                testIterations = 1;
                testType = "write";
                LaunchTestThread();
            }
            // not thread safe //testFileSize = Convert.ToUInt64(cbFileSize.Text) * 1000000;
            testFileSize = 500 * 1000000; //hårdkodat så länge B2

            // not thread safe //testIterations = Convert.ToUInt64(cbLoops.Text);
            testIterations = 3; //Så länge B2

            if (!loopBreak)
            { // Run write test
                testType = "write";
                LaunchTestThread();
            }
            if (!loopBreak)
            { // Run read test
                testType = "read";
                LaunchTestThread();
            }
            testIsActive = false;
            loopBreak = false;
            
            //benchmarkButton.Text = "Start";
        }

        private void LaunchTestThread()
        {
            //workerThread = new Thread(TestPerf);
            workerThread = new Thread(TestPerf3);
            workerThread.Start();
            while (!workerThread.IsAlive) ; // wait for thread activation
            while (workerThread.IsAlive) // wait for thread termination
            {
                Thread.Sleep(500);
            }
        }

        private void TestPerf2()
        {
            try
            {

                for (int i = 1; i <= 3; i++)
                {
                  Console.Beep(698, 100);
                    
                    //resultArea.AppendText(".");
                    Thread.Sleep(1000);
                }
                    
            }
            catch (Exception e)
            {
                resultArea.AppendText("An error occured: " + e.Message + "\r\n");
            }
        }
        private void TestPerf3()
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
                if (testType == "read")
                {
                    firstPath = testPath;
                    secondPath = localStoragePath;
                    shortType = "R";
                }
                else
                {
                    firstPath = localStoragePath;
                    secondPath = testPath;
                    shortType = "W";
                }
                if (testIterations == 1)
                {
                    iterText = "once";
                }
                else if (testIterations == 2)
                {
                    iterText = "twice";
                }
                else
                {
                    iterText = testIterations + " times";
                }
                if (testFileSize == 0)
                {
                    //resultArea.AppendText("Running warmup...\r\n");
                    //resultArea.Invalidate();
                    Console.Beep(698, 100);
                    appendIterations = 100; // equals a 10MB warmup file.
                }
                else
                {
                    //resultArea.AppendText(
                    //  "Running a " + testFileSize / 1000000 + "MB file " + testType +
                    //  " on " + testPath + " " + iterText + "...\r\n");
                    Console.Beep(698, 100);
                    appendIterations = testFileSize / 100000;
                    // Note: dividing integers in C# always produce a whole number,
                    // so no explicit rounding or type conversion is needed
                }
                totalPerf = 0;
                for (ulong j = 1; j <= testIterations; j++)
                {
                    Application.DoEvents();
                    if (File.Exists(firstPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(firstPath + "\\" + j + "test.tmp");
                    }
                    if (File.Exists(secondPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(secondPath + "\\" + j + "test.tmp");
                    }
                    if (loopBreak == true)
                    {
                        //resultArea.AppendText("Benchmark cancelled.\r\n");
                        //resultArea.Invalidate();
                        Console.Beep(698, 100);
                        break;
                    }
                    StreamWriter sWriter = new StreamWriter(firstPath +
                      "\\" + j + "test.tmp", true, Encoding.UTF8, 1048576);
                    for (ulong i = 1; i <= appendIterations; i++)
                    {
                        sWriter.Write(randomText);
                    }
                    sWriter.Close();
                    startTime = DateTime.Now;
                    File.Copy(firstPath + "\\" + j + "test.tmp",
                      secondPath + "\\" + j + "test.tmp");
                    stopTime = DateTime.Now;
                    File.Delete(firstPath + "\\" + j + "test.tmp");
                    File.Delete(secondPath + "\\" + j + "test.tmp");
                    TimeSpan interval = stopTime - startTime;
                    if (testIterations > 1)
                    {
                        //resultArea.AppendText(
                        //  ("Iteration " + j + ":").PadRight(15) +
                        //  ((testFileSize / 1000) / interval.TotalMilliseconds).ToString("F2").PadLeft(7) +
                        //  " MB/sec\r\n");
                        //resultArea.Invalidate();
                        Console.Beep(698, 100);
                    }
                    totalPerf += (testFileSize / 1000) / interval.TotalMilliseconds;
                }
                if ((testFileSize != 0) && (loopBreak == false))
                {
                    //resultArea.AppendText("-----------------------------\r\n");
                    //resultArea.AppendText("Average (" + shortType + "):" +
                    //  (totalPerf / testIterations).ToString("F2").PadLeft(10) + " MB/sec\r\n");
                    //resultArea.AppendText("-----------------------------\r\n");
                    //resultArea.Invalidate();
                    Console.Beep(698, 100);
                }
            }
            catch (Exception e)
            {
                //resultArea.AppendText("An error occured: " + e.Message + "\r\n");
                Console.Beep(440, 2000);
            }

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
                if (testType == "read")
                {
                    firstPath = testPath;
                    secondPath = localStoragePath;
                    shortType = "R";
                }
                else
                {
                    firstPath = localStoragePath;
                    secondPath = testPath;
                    shortType = "W";
                }
                if (testIterations == 1)
                {
                    iterText = "once";
                }
                else if (testIterations == 2)
                {
                    iterText = "twice";
                }
                else
                {
                    iterText = testIterations + " times";
                }
                if (testFileSize == 0)
                {
                    resultArea.AppendText("Running warmup...\r\n");
                    resultArea.Invalidate();
                    appendIterations = 100; // equals a 10MB warmup file.
                }
                else
                {
                    resultArea.AppendText(
                      "Running a " + testFileSize / 1000000 + "MB file " + testType +
                      " on " + testPath + " " + iterText + "...\r\n");
                    appendIterations = testFileSize / 100000;
                    // Note: dividing integers in C# always produce a whole number,
                    // so no explicit rounding or type conversion is needed
                }
                totalPerf = 0;
                for (ulong j = 1; j <= testIterations; j++)
                {
                    Application.DoEvents();
                    if (File.Exists(firstPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(firstPath + "\\" + j + "test.tmp");
                    }
                    if (File.Exists(secondPath + "\\" + j + "test.tmp"))
                    {
                        File.Delete(secondPath + "\\" + j + "test.tmp");
                    }
                    if (loopBreak == true)
                    {
                        resultArea.AppendText("Benchmark cancelled.\r\n");
                        resultArea.Invalidate();
                        break;
                    }
                    StreamWriter sWriter = new StreamWriter(firstPath +
                      "\\" + j + "test.tmp", true, Encoding.UTF8, 1048576);
                    for (ulong i = 1; i <= appendIterations; i++)
                    {
                        sWriter.Write(randomText);
                    }
                    sWriter.Close();
                    startTime = DateTime.Now;
                    File.Copy(firstPath + "\\" + j + "test.tmp",
                      secondPath + "\\" + j + "test.tmp");
                    stopTime = DateTime.Now;
                    File.Delete(firstPath + "\\" + j + "test.tmp");
                    File.Delete(secondPath + "\\" + j + "test.tmp");
                    TimeSpan interval = stopTime - startTime;
                    if (testIterations > 1)
                    {
                        resultArea.AppendText(
                          ("Iteration " + j + ":").PadRight(15) +
                          ((testFileSize / 1000) / interval.TotalMilliseconds).ToString("F2").PadLeft(7) +
                          " MB/sec\r\n");
                        resultArea.Invalidate();
                    }
                    totalPerf += (testFileSize / 1000) / interval.TotalMilliseconds;
                }
                if ((testFileSize != 0) && (loopBreak == false))
                {
                    resultArea.AppendText("-----------------------------\r\n");
                    resultArea.AppendText("Average (" + shortType + "):" +
                      (totalPerf / testIterations).ToString("F2").PadLeft(10) + " MB/sec\r\n");
                    resultArea.AppendText("-----------------------------\r\n");
                    resultArea.Invalidate();
                }
            }
            catch (Exception e)
            {
                resultArea.AppendText("An error occured: " + e.Message + "\r\n");
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

        private string[] GetNetworkDriveLetters()
        {
            System.Collections.ArrayList NetworkDriveLetters = new System.Collections.ArrayList();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType == DriveType.Network)
                {
                    NetworkDriveLetters.Add(d.Name.Substring(0, 1));
                }
            }
            return NetworkDriveLetters.ToArray(typeof(string)) as string[];
        }

        private bool IsFolderWritable(string folderPath)
        {
            try
            {
                using (FileStream fs = File.Create(
                  Path.Combine(folderPath, Path.GetRandomFileName()),
                  1, FileOptions.DeleteOnClose)
                  )
                { }
                return true;
            }
            catch
            {
                return false;
            }
        }







        private void btnInit_Click(object sender, EventArgs e)
        {
            lbNWPaths.Items.Add("C:\\");
            // MessageBox.Show  (cbLoops.Items.Count.ToString());
            cbLoops.SelectedIndex = 1;
            cbFileSize.SelectedIndex = 1;
            //MessageBox.Show (cbLoops.SelectedItem.ToString());

        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.
            // lbNWPaths.Items.Add( "hfhfh jfjf"); //erDialog1.SelectedPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbNWPaths.Items.Add(folderBrowserDialog1.SelectedPath);

            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings will be read...later");
            //MySettings settings = MySettings.Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings will be saved...later");
        }

        //private void SetText(string text)
        //{
        //    //https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(EHInvalidOperation.WinForms.IllegalCrossThreadCall);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)&rd=true

        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.
        //    if (this.resultArea.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SetText);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.resultArea.AppendText ( text);
        //    }
        //}
    }

}
