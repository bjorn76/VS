/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2015-01-31
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NoahApp01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(309, 163);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Tryck här om du våger....";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(3, 196);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(347, 176);
			this.webBrowser1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 170);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(291, 20);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.button2.Location = new System.Drawing.Point(29, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 32);
			this.button2.TabIndex = 3;
			this.button2.Text = "Pappa undrar?";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(29, 41);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(449, 41);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(225, 23);
			this.progressBar1.TabIndex = 6;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(699, 42);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "+10";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(352, 42);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "-10";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(525, 226);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(127, 23);
			this.button5.TabIndex = 9;
			this.button5.Text = "Gå till inställingar";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(786, 372);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "NoahApp01";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button button1;
	}
}
