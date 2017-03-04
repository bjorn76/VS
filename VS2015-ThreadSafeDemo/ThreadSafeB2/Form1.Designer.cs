namespace ThreadSafe
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
            this.setTextUnsafeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setTextSafeBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.setTextBackgroundWorkerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setTextUnsafeBtn
            // 
            this.setTextUnsafeBtn.Location = new System.Drawing.Point(12, 48);
            this.setTextUnsafeBtn.Name = "setTextUnsafeBtn";
            this.setTextUnsafeBtn.Size = new System.Drawing.Size(75, 23);
            this.setTextUnsafeBtn.TabIndex = 0;
            this.setTextUnsafeBtn.Text = "setTextUnsafeBtn";
            this.setTextUnsafeBtn.UseVisualStyleBackColor = true;
            this.setTextUnsafeBtn.Click += new System.EventHandler(this.setTextUnsafeBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            // 
            // setTextSafeBtn
            // 
            this.setTextSafeBtn.Location = new System.Drawing.Point(104, 48);
            this.setTextSafeBtn.Name = "setTextSafeBtn";
            this.setTextSafeBtn.Size = new System.Drawing.Size(93, 23);
            this.setTextSafeBtn.TabIndex = 2;
            this.setTextSafeBtn.Text = "setTextSafeBtn";
            this.setTextSafeBtn.UseVisualStyleBackColor = true;
            this.setTextSafeBtn.Click += new System.EventHandler(this.setTextSafeBtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // setTextBackgroundWorkerBtn
            // 
            this.setTextBackgroundWorkerBtn.Location = new System.Drawing.Point(12, 87);
            this.setTextBackgroundWorkerBtn.Name = "setTextBackgroundWorkerBtn";
            this.setTextBackgroundWorkerBtn.Size = new System.Drawing.Size(120, 23);
            this.setTextBackgroundWorkerBtn.TabIndex = 3;
            this.setTextBackgroundWorkerBtn.Text = "setTextBackgroundWorkerBtn";
            this.setTextBackgroundWorkerBtn.UseVisualStyleBackColor = true;
            this.setTextBackgroundWorkerBtn.Click += new System.EventHandler(this.setTextBackgroundWorkerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.setTextBackgroundWorkerBtn);
            this.Controls.Add(this.setTextSafeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.setTextUnsafeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setTextUnsafeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setTextSafeBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button setTextBackgroundWorkerBtn;
    }
}

