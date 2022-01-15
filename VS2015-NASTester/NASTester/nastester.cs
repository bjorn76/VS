using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Threading;
using System.Reflection;

[assembly: AssemblyTitle("NAS performance tester 1.7 - with B2 extra settings")]
[assembly: AssemblyDescription("A small C# utility for benchmarking the read and write performance of network attached storage")]
[assembly: AssemblyCompany("www.808.dk")]
[assembly: AssemblyProduct("NasTester")]
[assembly: AssemblyCopyright("Creative Commons Attribution (CC BY 3.0) http://creativecommons.org/licenses/by/3.0/ Reference source http://www.808.dk/?code-csharp-nas-performance")]
[assembly: AssemblyVersion("1.7.0.0")]
[assembly: CLSCompliant(true)]

public class NasPerformanceForm : Form
{
  private Label driveLetterLabel = new Label();
  private Label networkPathLabel = new Label();
  private Label fileSizeLabel = new Label();
  private Label loopsLabel = new Label();
  private Button benchmarkButton = new Button();
  private TextBox networkPath = new TextBox();
  private ComboBox driveLetter = new ComboBox();
  private ComboBox cbUNC = new ComboBox(); //B2
    private ComboBox fileSize = new ComboBox();
  private ComboBox loops = new ComboBox();
  private TextBox resultArea = new TextBox();
  private Label infoLabel = new Label();
  private LinkLabel urlLabel = new LinkLabel();
  private bool loopBreak = false;
  private string testPath;
  private ulong testFileSize;
  private ulong testIterations;
  private string testType;
  private string localStoragePath;
  private Thread workerThread;
  private bool testIsActive = false;

    public NasPerformanceForm()
    {
        this.Text = "NAS performance tester 1.7";
        this.Size = new Size(558, 400);
        this.Font = new Font("Microsoft Sans Serif", 8);
        driveLetterLabel.Location = new Point(5, 8);
        driveLetterLabel.Text = "NAS drive letter";
        driveLetterLabel.Size = new Size(83, 20);
        driveLetter.Location = new Point(90, 5);
        driveLetter.Size = new Size(33, 15);
        driveLetter.Items.AddRange(GetNetworkDriveLetters());
        if (GetNetworkDriveLetters().Length > 0)
        {
            driveLetter.SelectedIndex = 0;
        }
        networkPathLabel.Location = new Point(123, 8);
        networkPathLabel.Text = "or network path";
        networkPathLabel.Size = new Size(80, 20);
        networkPath.Location = new Point(205, 5);
        networkPath.Text = "C:\\Temp";
        networkPath.Size = new Size(90, 20);
        fileSizeLabel.Location = new Point(302, 8);
        fileSizeLabel.Text = "File size";
        fileSizeLabel.Size = new Size(50, 20);
        fileSize.Location = new Point(352, 5);
        fileSize.Size = new Size(49, 15);
        fileSize.Items.AddRange(new object[]
          {"20",
       "100",
       "200",
       "400",
       "800",
       "1000",
       "2000",
       "4000",
       "8000"});
        fileSize.SelectedIndex = 0;
        loopsLabel.Location = new Point(407, 8);
        loopsLabel.Text = "Loops";
        loopsLabel.Size = new Size(36, 20);
        loops.Location = new Point(443, 5);
        loops.Size = new Size(37, 15);
        loops.Items.AddRange(new object[]
          {"1",
       "2",
       "3",
       "4",
       "5",
       "10",
       "20",
       "40"});
        loops.SelectedIndex = 4;
        //cbUNC

        cbUNC.Location = new Point(900, 8);
        cbUNC.Items.AddRange(new object[]
        { "Hej",
        "svej"

        });


        benchmarkButton.Location = new Point(487, 5);
    benchmarkButton.Size = new Size(50, 20);
    benchmarkButton.Text = "Start";
    resultArea.Location = new Point(5, 30);
    resultArea.Size = new Size(533,305);
    resultArea.ReadOnly = true;
    resultArea.Multiline = true;
    resultArea.ScrollBars = ScrollBars.Vertical;
    resultArea.WordWrap = false;
    resultArea.Text = "NAS performance tester 1.7 http://www.808.dk/?nastester\r\n";
    resultArea.Font = new Font("Courier New", 8);
    infoLabel.Location = new Point(5, 341);
    infoLabel.Text = "For more information, visit";
    infoLabel.Size = new Size(140, 20);
    urlLabel.Location = new Point(143, 341);
    urlLabel.Text = "http://www.808.dk/?code-csharp-nas-performance";
    urlLabel.Links.Add(0, 46, "http://www.808.dk/?code-csharp-nas-performance");
    urlLabel.Size = new Size(300, 20);
    this.Controls.Add(driveLetterLabel);
    this.Controls.Add(driveLetter);
    this.Controls.Add(networkPathLabel);
    this.Controls.Add(networkPath);
    this.Controls.Add(fileSizeLabel);
    this.Controls.Add(fileSize);
    this.Controls.Add(loopsLabel);
    this.Controls.Add(loops);
    this.Controls.Add(benchmarkButton);
    this.Controls.Add(resultArea);
    this.Controls.Add(infoLabel);
    this.Controls.Add(urlLabel);
        this.Controls.Add(cbUNC); //B2
    benchmarkButton.Click += new EventHandler(benchmarkButton_Click);
    urlLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.urlLabel_LinkClicked);
    this.ActiveControl = networkPath;
    if (IsFolderWritable(Path.GetDirectoryName(Application.ExecutablePath)))
    {
      localStoragePath = Path.GetDirectoryName(Application.ExecutablePath);
    }
    else // Write access to program folder denied, falling back to Windows temp folder as defined in the environment variables
    {
      localStoragePath = Path.GetTempPath();
    }
  }

  private void benchmarkButton_Click(object sender, EventArgs e)
  {
    if (!testIsActive)
    {
      int checkFileSize;
      int checkLoops;
      if ((!String.IsNullOrEmpty(driveLetter.Text) || (networkPath.Text.IndexOf("\\\\") == 0 && networkPath.Text.IndexOf("\\", 2) > 2)) &&
          int.TryParse(fileSize.Text, out checkFileSize) &&
          int.TryParse(loops.Text, out checkLoops))
      {
        if(checkFileSize <= 64000)
        {
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

  private void urlLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string target = e.Link.LinkData as string;
    System.Diagnostics.Process.Start(target);
  }

  private void BenchmarkHandler()
  {
    testIsActive = true;
    loopBreak = false;
    //benchmarkButton.Text = "Stop"; //B2 throws exceptioin. Cross thread issues?
    if (String.IsNullOrEmpty(networkPath.Text))
    {
      testPath = driveLetter.Text + ":";
    }
    else
    {
      testPath = networkPath.Text;
    }
    if (!loopBreak)
    { // Run warmup
      testFileSize = 0; // for warmup run
      testIterations = 1;
      testType = "write";
      LaunchTestThread();
    }
    testFileSize = Convert.ToUInt64(fileSize.Text) * 1000000;
    testIterations = Convert.ToUInt64(loops.Text);
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
    benchmarkButton.Text = "Start";
  }

  private void LaunchTestThread()
  {
    workerThread = new Thread(TestPerf);
    workerThread.Start();
    while (!workerThread.IsAlive); // wait for thread activation
    while (workerThread.IsAlive) // wait for thread termination
    {
      Thread.Sleep(500);
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
          "Running a " + testFileSize/1000000 + "MB file " + testType +
          " on " + testPath + " " + iterText + "...\r\n");
        appendIterations = testFileSize/100000;
        // Note: dividing integers in C# always produce a whole number,
        // so no explicit rounding or type conversion is needed
      }
      totalPerf = 0;
      for(ulong j=1; j<=testIterations; j++)
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
        for(ulong i=1; i<=appendIterations; i++)
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
        totalPerf += (testFileSize/1000)/interval.TotalMilliseconds;
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

  static void Main()
  {
    Application.Run(new NasPerformanceForm());

  }
}