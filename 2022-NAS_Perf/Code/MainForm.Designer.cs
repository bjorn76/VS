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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.driveLetterLabel = new System.Windows.Forms.Label();
            this.networkPathLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.loopsLabel = new System.Windows.Forms.Label();
            this.benchmarkButton = new System.Windows.Forms.Button();
            this.networkPath = new System.Windows.Forms.TextBox();
            this.driveLetterCombo = new System.Windows.Forms.ComboBox();
            this.fileSizeCombo = new System.Windows.Forms.ComboBox();
            this.loopsCombo = new System.Windows.Forms.ComboBox();
            this.resultArea = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.LinkLabel();
            this.setDefaultButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.Location = new System.Drawing.Point(54, 60);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(83, 20);
            this.driveLetterLabel.TabIndex = 0;
            this.driveLetterLabel.Text = "NAS drive letter:";
            // 
            // networkPathLabel
            // 
            this.networkPathLabel.Location = new System.Drawing.Point(54, 6);
            this.networkPathLabel.Name = "networkPathLabel";
            this.networkPathLabel.Size = new System.Drawing.Size(299, 23);
            this.networkPathLabel.TabIndex = 0;
            this.networkPathLabel.Text = "NAS Network Path (UNC):";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.Location = new System.Drawing.Point(493, 4);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(100, 23);
            this.fileSizeLabel.TabIndex = 0;
            this.fileSizeLabel.Text = "File Size (MB):";
            // 
            // loopsLabel
            // 
            this.loopsLabel.Location = new System.Drawing.Point(493, 60);
            this.loopsLabel.Name = "loopsLabel";
            this.loopsLabel.Size = new System.Drawing.Size(134, 23);
            this.loopsLabel.TabIndex = 0;
            this.loopsLabel.Text = "Loops:";
            // 
            // benchmarkButton
            // 
            this.benchmarkButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.benchmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benchmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("benchmarkButton.Image")));
            this.benchmarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.benchmarkButton.Location = new System.Drawing.Point(600, 449);
            this.benchmarkButton.Name = "benchmarkButton";
            this.benchmarkButton.Size = new System.Drawing.Size(98, 43);
            this.benchmarkButton.TabIndex = 0;
            this.benchmarkButton.Text = "Start";
            this.benchmarkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.benchmarkButton.UseVisualStyleBackColor = false;
            this.benchmarkButton.Click += new System.EventHandler(this.benchmarkButton_Click);
            // 
            // networkPath
            // 
            this.networkPath.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkPath.Location = new System.Drawing.Point(57, 32);
            this.networkPath.Name = "networkPath";
            this.networkPath.Size = new System.Drawing.Size(342, 27);
            this.networkPath.TabIndex = 0;
            this.networkPath.Text = "C:\\temp";
            // 
            // driveLetterCombo
            // 
            this.driveLetterCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveLetterCombo.Location = new System.Drawing.Point(57, 83);
            this.driveLetterCombo.Name = "driveLetterCombo";
            this.driveLetterCombo.Size = new System.Drawing.Size(121, 28);
            this.driveLetterCombo.TabIndex = 0;
            // 
            // fileSizeCombo
            // 
            this.fileSizeCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeCombo.Items.AddRange(new object[] {
            "100",
            "200",
            "400",
            "800",
            "1000",
            "2000",
            "4000",
            "8000"});
            this.fileSizeCombo.Location = new System.Drawing.Point(496, 30);
            this.fileSizeCombo.Name = "fileSizeCombo";
            this.fileSizeCombo.Size = new System.Drawing.Size(94, 28);
            this.fileSizeCombo.TabIndex = 0;
            // 
            // loopsCombo
            // 
            this.loopsCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopsCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "40"});
            this.loopsCombo.Location = new System.Drawing.Point(496, 83);
            this.loopsCombo.Name = "loopsCombo";
            this.loopsCombo.Size = new System.Drawing.Size(94, 28);
            this.loopsCombo.TabIndex = 0;
            // 
            // resultArea
            // 
            this.resultArea.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultArea.Font = new System.Drawing.Font("Courier New", 8F);
            this.resultArea.Location = new System.Drawing.Point(33, 151);
            this.resultArea.Multiline = true;
            this.resultArea.Name = "resultArea";
            this.resultArea.ReadOnly = true;
            this.resultArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultArea.Size = new System.Drawing.Size(685, 279);
            this.resultArea.TabIndex = 0;
            this.resultArea.Text = "NAS performance tester 1.7";
            this.resultArea.WordWrap = false;
            this.resultArea.TextChanged += new System.EventHandler(this.resultArea_TextChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoEllipsis = true;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(195, 60);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(204, 68);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Type in a network path If Emtyp will selected NAS drive letter be used.";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 46);
            this.urlLabel.Location = new System.Drawing.Point(44, 462);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(322, 17);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "http://www.808.dk/?code-csharp-nas-performance";
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.Location = new System.Drawing.Point(643, 12);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(75, 23);
            this.setDefaultButton.TabIndex = 2;
            this.setDefaultButton.Text = "Default";
            this.setDefaultButton.UseVisualStyleBackColor = true;
            this.setDefaultButton.Click += new System.EventHandler(this.SetDefaultButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(769, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.setDefaultButton);
            this.Controls.Add(this.benchmarkButton);
            this.Controls.Add(this.networkPathLabel);
            this.Controls.Add(this.networkPath);
            this.Controls.Add(this.driveLetterLabel);
            this.Controls.Add(this.driveLetterCombo);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileSizeCombo);
            this.Controls.Add(this.loopsLabel);
            this.Controls.Add(this.loopsCombo);
            this.Controls.Add(this.resultArea);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.urlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NAS performance tester 1.7 - With B2 modifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private Label driveLetterLabel;
        private ComboBox driveLetterCombo;
        private Label networkPathLabel;
        private TextBox networkPath;
        private Label fileSizeLabel;
        private ComboBox fileSizeCombo;
        private Label loopsLabel;
        private ComboBox loopsCombo;
        private Button benchmarkButton;
        private TextBox resultArea;
        private Label infoLabel;
        private LinkLabel urlLabel;
        private Button setDefaultButton;
        private StatusStrip statusStrip1;
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

