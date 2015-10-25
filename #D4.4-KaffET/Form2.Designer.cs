/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2011-05-28
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KaffET
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Stop = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblCountdown = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(323, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "TestAlarm (+1 min)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(323, 266);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(118, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "alarm.stop";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Stop);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblCountdown);
			this.groupBox1.Location = new System.Drawing.Point(25, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(183, 96);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "\"Form timer1 alarm\"";
			// 
			// Stop
			// 
			this.Stop.Location = new System.Drawing.Point(88, 60);
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(75, 23);
			this.Stop.TabIndex = 15;
			this.Stop.Text = "Stop";
			this.Stop.UseVisualStyleBackColor = true;
			this.Stop.Click += new System.EventHandler(this.StopClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "3 sec";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblCountdown
			// 
			this.lblCountdown.BackColor = System.Drawing.Color.Black;
			this.lblCountdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCountdown.ForeColor = System.Drawing.Color.Lime;
			this.lblCountdown.Location = new System.Drawing.Point(76, 16);
			this.lblCountdown.Name = "lblCountdown";
			this.lblCountdown.Size = new System.Drawing.Size(87, 30);
			this.lblCountdown.TabIndex = 13;
			this.lblCountdown.Text = "Countdown";
			this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Location = new System.Drawing.Point(25, 114);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(183, 92);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DateTime test";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 48);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(63, 23);
			this.button5.TabIndex = 19;
			this.button5.Text = "alarm";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(88, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "00:00";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "00:00";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 19);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(63, 23);
			this.button4.TabIndex = 17;
			this.button4.Text = "Now";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 362);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "Form2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblCountdown;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.Button button1;
		

	}
}
