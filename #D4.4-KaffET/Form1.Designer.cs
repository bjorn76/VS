namespace PC_AlarmClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1min = new System.Windows.Forms.Button();
            this.button2min = new System.Windows.Forms.Button();
            this.button3min = new System.Windows.Forms.Button();
            this.button4min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5min = new System.Windows.Forms.Button();
            this.button10min = new System.Windows.Forms.Button();
            this.button15min = new System.Windows.Forms.Button();
            this.button20min = new System.Windows.Forms.Button();
            this.button30min = new System.Windows.Forms.Button();
            this.button45min = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1min
            // 
            this.button1min.Location = new System.Drawing.Point(52, 86);
            this.button1min.Name = "button1min";
            this.button1min.Size = new System.Drawing.Size(75, 23);
            this.button1min.TabIndex = 0;
            this.button1min.Text = "1 min";
            this.button1min.UseVisualStyleBackColor = true;
            this.button1min.Click += new System.EventHandler(this.button1min_Click);
            // 
            // button2min
            // 
            this.button2min.Location = new System.Drawing.Point(52, 115);
            this.button2min.Name = "button2min";
            this.button2min.Size = new System.Drawing.Size(75, 23);
            this.button2min.TabIndex = 1;
            this.button2min.Text = "2 min";
            this.button2min.UseVisualStyleBackColor = true;
            this.button2min.Click += new System.EventHandler(this.button2min_Click);
            // 
            // button3min
            // 
            this.button3min.Location = new System.Drawing.Point(52, 144);
            this.button3min.Name = "button3min";
            this.button3min.Size = new System.Drawing.Size(75, 23);
            this.button3min.TabIndex = 2;
            this.button3min.Text = "3 min";
            this.button3min.UseVisualStyleBackColor = true;
            this.button3min.Click += new System.EventHandler(this.button3min_Click);
            // 
            // button4min
            // 
            this.button4min.Location = new System.Drawing.Point(52, 173);
            this.button4min.Name = "button4min";
            this.button4min.Size = new System.Drawing.Size(75, 23);
            this.button4min.TabIndex = 3;
            this.button4min.Text = "4 min";
            this.button4min.UseVisualStyleBackColor = true;
            this.button4min.Click += new System.EventHandler(this.button4min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Timer:";
            // 
            // button5min
            // 
            this.button5min.Location = new System.Drawing.Point(52, 202);
            this.button5min.Name = "button5min";
            this.button5min.Size = new System.Drawing.Size(75, 23);
            this.button5min.TabIndex = 5;
            this.button5min.Text = "5 min";
            this.button5min.UseVisualStyleBackColor = true;
            this.button5min.Click += new System.EventHandler(this.button5min_Click);
            // 
            // button10min
            // 
            this.button10min.Location = new System.Drawing.Point(164, 86);
            this.button10min.Name = "button10min";
            this.button10min.Size = new System.Drawing.Size(75, 23);
            this.button10min.TabIndex = 6;
            this.button10min.Text = "10 min";
            this.button10min.UseVisualStyleBackColor = true;
            this.button10min.Click += new System.EventHandler(this.button10min_Click);
            // 
            // button15min
            // 
            this.button15min.Location = new System.Drawing.Point(164, 115);
            this.button15min.Name = "button15min";
            this.button15min.Size = new System.Drawing.Size(75, 23);
            this.button15min.TabIndex = 7;
            this.button15min.Text = "15 mins";
            this.button15min.UseVisualStyleBackColor = true;
            this.button15min.Click += new System.EventHandler(this.button15min_Click);
            // 
            // button20min
            // 
            this.button20min.Location = new System.Drawing.Point(164, 144);
            this.button20min.Name = "button20min";
            this.button20min.Size = new System.Drawing.Size(75, 23);
            this.button20min.TabIndex = 8;
            this.button20min.Text = "20 mins";
            this.button20min.UseVisualStyleBackColor = true;
            this.button20min.Click += new System.EventHandler(this.button20min_Click);
            // 
            // button30min
            // 
            this.button30min.Location = new System.Drawing.Point(164, 173);
            this.button30min.Name = "button30min";
            this.button30min.Size = new System.Drawing.Size(75, 23);
            this.button30min.TabIndex = 9;
            this.button30min.Text = "30 mins";
            this.button30min.UseVisualStyleBackColor = true;
            this.button30min.Click += new System.EventHandler(this.button30min_Click);
            // 
            // button45min
            // 
            this.button45min.Location = new System.Drawing.Point(164, 202);
            this.button45min.Name = "button45min";
            this.button45min.Size = new System.Drawing.Size(75, 23);
            this.button45min.TabIndex = 10;
            this.button45min.Text = "45 mins";
            this.button45min.UseVisualStyleBackColor = true;
            this.button45min.Click += new System.EventHandler(this.button45min_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.BackColor = System.Drawing.Color.Black;
            this.lblCountdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountdown.ForeColor = System.Drawing.Color.Lime;
            this.lblCountdown.Location = new System.Drawing.Point(142, 9);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(87, 30);
            this.lblCountdown.TabIndex = 11;
            this.lblCountdown.Text = "Countdown";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(110, 231);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seconds:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.button45min);
            this.Controls.Add(this.button30min);
            this.Controls.Add(this.button20min);
            this.Controls.Add(this.button15min);
            this.Controls.Add(this.button10min);
            this.Controls.Add(this.button5min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4min);
            this.Controls.Add(this.button3min);
            this.Controls.Add(this.button2min);
            this.Controls.Add(this.button1min);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PC Alarm Clock 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1min;
        private System.Windows.Forms.Button button2min;
        private System.Windows.Forms.Button button3min;
        private System.Windows.Forms.Button button4min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5min;
        private System.Windows.Forms.Button button10min;
        private System.Windows.Forms.Button button15min;
        private System.Windows.Forms.Button button20min;
        private System.Windows.Forms.Button button30min;
        private System.Windows.Forms.Button button45min;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label2;
    }
}

