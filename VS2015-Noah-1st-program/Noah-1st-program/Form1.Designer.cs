namespace Noah_1st_program
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
            this.button1 = new System.Windows.Forms.Button();
            this.smileyoskar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnBaloonTip = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.smileyoskar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // smileyoskar
            // 
            this.smileyoskar.BackColor = System.Drawing.Color.Transparent;
            this.smileyoskar.Image = ((System.Drawing.Image)(resources.GetObject("smileyoskar.Image")));
            this.smileyoskar.Location = new System.Drawing.Point(865, 117);
            this.smileyoskar.Margin = new System.Windows.Forms.Padding(2);
            this.smileyoskar.Name = "smileyoskar";
            this.smileyoskar.Size = new System.Drawing.Size(204, 204);
            this.smileyoskar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.smileyoskar.TabIndex = 3;
            this.smileyoskar.TabStop = false;
            this.toolTip1.SetToolTip(this.smileyoskar, "Hej");
            this.smileyoskar.Click += new System.EventHandler(this.smileyoskar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 33);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnBaloonTip
            // 
            this.btnBaloonTip.Location = new System.Drawing.Point(322, 126);
            this.btnBaloonTip.Name = "btnBaloonTip";
            this.btnBaloonTip.Size = new System.Drawing.Size(75, 23);
            this.btnBaloonTip.TabIndex = 7;
            this.btnBaloonTip.Text = "BaloonTip";
            this.btnBaloonTip.UseVisualStyleBackColor = true;
            this.btnBaloonTip.Click += new System.EventHandler(this.btnBaloonTip_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(361, 61);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "Tool tip";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 287);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnBaloonTip);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.smileyoskar);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "happy :)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smileyoskar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox smileyoskar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnBaloonTip;
        private System.Windows.Forms.Button btnT;
    }
}

