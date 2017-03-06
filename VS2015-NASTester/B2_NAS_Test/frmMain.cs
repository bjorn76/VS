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
        private string testPath="c:";
        private ulong testFileSize = 10;
        private ulong testIterations = 2;
        private string testType;
        private string localStoragePath = "c:";
        private bool testIsActive = false;

        private string rText = "init";
        public string resultText
        {
            get
            {
                return rText;
            }
            set
            {
                rText = value + Environment.NewLine;
            }
        }

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
            this.backgroundWorker1.RunWorkerAsync();

        }
        // like Benchmarkhandler
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            testIsActive = true;
            loopBreak = false;

            testPath = "c:";


            if (!loopBreak)
            { // Run warmup
                testFileSize = 0; // for warmup run
                testIterations = 1;
                testType = "write";
                this.backgroundWorker2.RunWorkerAsync();
            }

            //// not thread safe //testFileSize = Convert.ToUInt64(cbFileSize.Text) * 1000000;
            //testFileSize = 500 * 1000000; //hårdkodat så länge B2

            //// not thread safe //testIterations = Convert.ToUInt64(cbLoops.Text);
            //testIterations = 3; //Så länge B2

            //if (!loopBreak)
            //{ // Run write test
            //    testType = "write";
            //    this.backgroundWorker2.RunWorkerAsync();
            //}
            //if (!loopBreak)
            //{ // Run read test
            //    testType = "read";
            //    this.backgroundWorker2.RunWorkerAsync(); 
            //}
            

            testIsActive = false;
            loopBreak = false;


        }



        //TestPerf
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
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
                    resultText += "Running warmup..." + Environment.NewLine;
                    Console.Beep(698, 100);
                    appendIterations = 100; // equals a 10MB warmup file.
                }
                else
                {
                    //resultArea.AppendText(
                    //  "Running a " + testFileSize / 1000000 + "MB file " + testType +
                    //  " on " + testPath + " " + iterText + "...\r\n");
                    resultText += "Running a test file..." + Environment.NewLine;
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
                        resultText += "Benchmark cancelled." + Environment.NewLine;
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
                        resultText += "Iteration" + j.ToString();
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
                    resultText += (totalPerf / testIterations).ToString();
                    Console.Beep(698, 100);
                }
            }
            catch (Exception eee)
            {
                //resultArea.AppendText("An error occured: " + e.Message + "\r\n");
                resultText += "An error occured: " + eee.Message;
                Console.Beep(440, 2000);
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resultArea.AppendText("bgWorker completed" + Environment.NewLine);

            if (!string.IsNullOrEmpty(this.resultText))
            {

                resultArea.AppendText(this.resultText);
                resultText = "";
            }
            else
            {
                resultArea.AppendText("resultText IsNullOrEmptyis");
            };

        }

    
    }
}

