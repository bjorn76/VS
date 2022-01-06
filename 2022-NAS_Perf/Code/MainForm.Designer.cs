using System;
using System.Drawing;
using System.Windows.Forms;

namespace NASPerformanceTester
{
    partial class MainForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.driveLetterLabel = new System.Windows.Forms.Label();
            this.networkPathLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.loopsLabel = new System.Windows.Forms.Label();
            this.benchmarkButton = new System.Windows.Forms.Button();
            this.networkPath = new System.Windows.Forms.TextBox();
            this.driveLetter = new System.Windows.Forms.ComboBox();
            this.fileSize = new System.Windows.Forms.ComboBox();
            this.loops = new System.Windows.Forms.ComboBox();
            this.resultArea = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.Location = new System.Drawing.Point(5, 8);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(83, 20);
            this.driveLetterLabel.TabIndex = 0;
            this.driveLetterLabel.Text = "NAS drive letter";
            // 
            // networkPathLabel
            // 
            this.networkPathLabel.Location = new System.Drawing.Point(404, 86);
            this.networkPathLabel.Name = "networkPathLabel";
            this.networkPathLabel.Size = new System.Drawing.Size(100, 23);
            this.networkPathLabel.TabIndex = 0;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.Location = new System.Drawing.Point(0, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(100, 23);
            this.fileSizeLabel.TabIndex = 0;
            // 
            // loopsLabel
            // 
            this.loopsLabel.Location = new System.Drawing.Point(0, 0);
            this.loopsLabel.Name = "loopsLabel";
            this.loopsLabel.Size = new System.Drawing.Size(100, 23);
            this.loopsLabel.TabIndex = 0;
            // 
            // benchmarkButton
            // 
            this.benchmarkButton.Location = new System.Drawing.Point(424, 386);
            this.benchmarkButton.Name = "benchmarkButton";
            this.benchmarkButton.Size = new System.Drawing.Size(142, 43);
            this.benchmarkButton.TabIndex = 0;
            this.benchmarkButton.Text = "benchmarkButton";
            this.benchmarkButton.Click += new EventHandler(benchmarkButton_Click);
            // 
            // networkPath
            // 
            this.networkPath.Location = new System.Drawing.Point(252, 24);
            this.networkPath.Name = "networkPath";
            this.networkPath.Size = new System.Drawing.Size(100, 22);
            this.networkPath.TabIndex = 0;
            this.networkPath.Text = "C:\\temp";
            // 
            // driveLetter
            // 
            this.driveLetter.Location = new System.Drawing.Point(0, 0);
            this.driveLetter.Name = "driveLetter";
            this.driveLetter.Size = new System.Drawing.Size(121, 25);
            this.driveLetter.TabIndex = 0;
            // 
            // fileSize
            // 
            this.fileSize.Items.AddRange(new object[] {
            "100",
            "200",
            "400",
            "800",
            "1000",
            "2000",
            "4000",
            "8000"});
            this.fileSize.Location = new System.Drawing.Point(407, 22);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(121, 24);
            this.fileSize.TabIndex = 0;
            // 
            // loops
            // 
            this.loops.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "40"});
            this.loops.Location = new System.Drawing.Point(576, 22);
            this.loops.Name = "loops";
            this.loops.Size = new System.Drawing.Size(80, 24);
            this.loops.TabIndex = 0;
            // 
            // resultArea
            // 
            this.resultArea.Font = new System.Drawing.Font("Courier New", 8F);
            this.resultArea.Location = new System.Drawing.Point(33, 70);
            this.resultArea.Multiline = true;
            this.resultArea.Name = "resultArea";
            this.resultArea.ReadOnly = true;
            this.resultArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultArea.Size = new System.Drawing.Size(533, 305);
            this.resultArea.TabIndex = 0;
            this.resultArea.Text = "NAS performance tester 1.7 http://www.808.dk/?nastester\r\n";
            this.resultArea.WordWrap = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(100, 23);
            this.infoLabel.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 46);
            this.urlLabel.Location = new System.Drawing.Point(39, 399);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(322, 17);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "http://www.808.dk/?code-csharp-nas-performance";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1107, 540);
            this.Controls.Add(this.benchmarkButton);
            this.Controls.Add(this.networkPath);
            this.Controls.Add(this.networkPathLabel);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.loops);
            this.Controls.Add(this.loopsLabel);
            this.Controls.Add(this.resultArea);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.urlLabel);
            this.Name = "MainForm";
            this.Text = "NAS performance tester 1.7 B2 Froms design";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private Label driveLetterLabel;
        private Label networkPathLabel;
        private Label fileSizeLabel;
        private Label loopsLabel;
        private Button benchmarkButton;
        private TextBox networkPath;
        private ComboBox driveLetter;
        private ComboBox fileSize;
        private ComboBox loops;
        private TextBox resultArea;
        private Label infoLabel;
        private LinkLabel urlLabel;
    }

    /*
private System.ComponentModel.IContainer components = null;
private Label driveLetterLabel = new Label();
private Label networkPathLabel = new Label();
private Label fileSizeLabel = new Label();
private Label loopsLabel = new Label();
private Button benchmarkButton = new Button();
private TextBox networkPath = new TextBox();
private ComboBox driveLetter = new ComboBox();
private ComboBox fileSize = new ComboBox();
private ComboBox loops = new ComboBox();
private TextBox resultArea = new TextBox();
private Label infoLabel = new Label();
private LinkLabel urlLabel = new LinkLabel();
*/


    /*
private void InitializeComponent()
{
    this.components = new System.ComponentModel.Container();
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Text = "NAS performance tester 1.7";
    this.Size = new Size(558, 400);
    this.Font = new Font("Microsoft Sans Serif", 8);

    driveLetterLabel.Location = new Point(5, 8);
    driveLetterLabel.Text = "NAS drive letter";
    driveLetterLabel.Size = new Size(83, 20);
    driveLetter.Location = new Point(90, 5);
    driveLetter.Size = new Size(33, 15);

    networkPathLabel.Location = new Point(123, 8);
    networkPathLabel.Text = "or network path";
    networkPathLabel.Size = new Size(80, 20);

    loopsLabel.Location = new Point(407, 8);
    loopsLabel.Text = "Loops";
    loopsLabel.Size = new Size(36, 20);

    networkPath.Location = new Point(205, 5);
    networkPath.Text = "";
    networkPath.Size = new Size(90, 20);
    fileSizeLabel.Location = new Point(302, 8);
    fileSizeLabel.Text = "File size";
    fileSizeLabel.Size = new Size(50, 20);
    fileSize.Location = new Point(352, 5);
    fileSize.Size = new Size(49, 15);
    fileSize.Items.AddRange(
        new object[]
        {
            "100",
            "200",
            "400",
            "800",
            "1000",
            "2000",
            "4000",
            "8000"
        });
    fileSize.SelectedIndex = 2;

    loops.Location = new Point(443, 5);
    loops.Size = new Size(37, 15);
    loops.Items.AddRange(
        new object[]
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "40"
        });
    loops.SelectedIndex = 4;
    benchmarkButton.Location = new Point(487, 5);
    benchmarkButton.Size = new Size(50, 20);
    benchmarkButton.Text = "Start";
    resultArea.Location = new Point(5, 30);
    resultArea.Size = new Size(533, 305);
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

    benchmarkButton.Click += new EventHandler(benchmarkButton_Click);
    urlLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.urlLabel_LinkClicked);

    this.Controls.Add(loopsLabel);
    this.Controls.Add(driveLetterLabel);
    this.Controls.Add(networkPathLabel);
    this.Controls.Add(driveLetter);
    this.Controls.Add(networkPath);
    this.Controls.Add(fileSizeLabel);
    this.Controls.Add(fileSize);
    this.Controls.Add(loops);
    this.Controls.Add(benchmarkButton);
    this.Controls.Add(resultArea);
    this.Controls.Add(infoLabel);
    this.Controls.Add(urlLabel);
}
*/


}

