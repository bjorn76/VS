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
            this.LinkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.Location = new System.Drawing.Point(5, 58);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(100, 20);
            this.driveLetterLabel.TabIndex = 0;
            this.driveLetterLabel.Text = "NAS drive letter:";
            this.driveLetterLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // networkPathLabel
            // 
            this.networkPathLabel.Location = new System.Drawing.Point(5, 4);
            this.networkPathLabel.Name = "networkPathLabel";
            this.networkPathLabel.Size = new System.Drawing.Size(299, 23);
            this.networkPathLabel.TabIndex = 0;
            this.networkPathLabel.Text = "NAS Network Path (UNC):";
            this.networkPathLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.Location = new System.Drawing.Point(493, 4);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(100, 23);
            this.fileSizeLabel.TabIndex = 0;
            this.fileSizeLabel.Text = "File Size (MB):";
            this.fileSizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // loopsLabel
            // 
            this.loopsLabel.Location = new System.Drawing.Point(493, 60);
            this.loopsLabel.Name = "loopsLabel";
            this.loopsLabel.Size = new System.Drawing.Size(134, 23);
            this.loopsLabel.TabIndex = 0;
            this.loopsLabel.Text = "Loops:";
            this.loopsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // benchmarkButton
            // 
            this.benchmarkButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.benchmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benchmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("benchmarkButton.Image")));
            this.benchmarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.benchmarkButton.Location = new System.Drawing.Point(379, 58);
            this.benchmarkButton.Name = "benchmarkButton";
            this.benchmarkButton.Size = new System.Drawing.Size(75, 43);
            this.benchmarkButton.TabIndex = 0;
            this.benchmarkButton.Text = "Start";
            this.benchmarkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.benchmarkButton.UseVisualStyleBackColor = false;
            this.benchmarkButton.Click += new System.EventHandler(this.benchmarkButton_Click);
            // 
            // networkPath
            // 
            this.networkPath.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkPath.Location = new System.Drawing.Point(8, 30);
            this.networkPath.Name = "networkPath";
            this.networkPath.Size = new System.Drawing.Size(342, 23);
            this.networkPath.TabIndex = 0;
            this.networkPath.Text = "C:\\temp";
            // 
            // driveLetterCombo
            // 
            this.driveLetterCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveLetterCombo.Location = new System.Drawing.Point(8, 83);
            this.driveLetterCombo.Name = "driveLetterCombo";
            this.driveLetterCombo.Size = new System.Drawing.Size(121, 25);
            this.driveLetterCombo.TabIndex = 0;
            // 
            // fileSizeCombo
            // 
            this.fileSizeCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeCombo.Location = new System.Drawing.Point(496, 30);
            this.fileSizeCombo.Name = "fileSizeCombo";
            this.fileSizeCombo.Size = new System.Drawing.Size(94, 25);
            this.fileSizeCombo.TabIndex = 0;
            // 
            // loopsCombo
            // 
            this.loopsCombo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopsCombo.Location = new System.Drawing.Point(496, 83);
            this.loopsCombo.Name = "loopsCombo";
            this.loopsCombo.Size = new System.Drawing.Size(94, 25);
            this.loopsCombo.TabIndex = 0;
            // 
            // resultArea
            // 
            this.resultArea.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultArea.Font = new System.Drawing.Font("Courier New", 8F);
            this.resultArea.Location = new System.Drawing.Point(8, 114);
            this.resultArea.Multiline = true;
            this.resultArea.Name = "resultArea";
            this.resultArea.ReadOnly = true;
            this.resultArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultArea.Size = new System.Drawing.Size(582, 302);
            this.resultArea.TabIndex = 0;
            this.resultArea.Text = "NAS performance tester 1.7";
            this.resultArea.WordWrap = false;
            
            // 
            // infoLabel
            // 
            this.infoLabel.AutoEllipsis = true;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(146, 58);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(204, 50);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Type in a network path (If emty will selected drive letter be used) and click Sta" +
    "rt";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 46);
            this.urlLabel.Location = new System.Drawing.Point(168, 419);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(261, 30);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "http://www.808.dk/?code-csharp-nas-performance\r\n\r\n";
            this.urlLabel.UseCompatibleTextRendering = true;
            this.urlLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLabel_LinkClicked);
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.Location = new System.Drawing.Point(379, 29);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(75, 23);
            this.setDefaultButton.TabIndex = 2;
            this.setDefaultButton.Text = "Default";
            this.setDefaultButton.UseVisualStyleBackColor = true;
            this.setDefaultButton.Click += new System.EventHandler(this.SetDefaultButton_Click);
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(12, 419);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(150, 13);
            this.LinkLabel.TabIndex = 4;
            this.LinkLabel.Text = "With C# code originating from:";
            // 
            // MainForm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.LinkLabel);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 500);
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
        private Label LinkLabel;
    }




}

