using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Noah_1st_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              // MessageBox.Show("message", "Noah"); //OK

        }

        private void smileyoskar_Click(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {

            
            
         }



        private void button2_Click(object sender, EventArgs e)
        {
            Point np = smileyoskar.Location; //OK
            np.Offset(-100, 0); //OK
            smileyoskar.Location = np; //OK
            Thread.Sleep(500); //OK
            Form1.ActiveForm.Width = Form1.ActiveForm.Size.Width - 100; //OK
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //shows Point and Size objects and asignments.
            button2.Location = new Point(200, 200);
            //button2.Size = new Size(50, 100);
            button2.Size = new Size(button2.Size.Width + 10, button2.Size.Height + 10);
            Form1.ActiveForm.Width = Form1.ActiveForm.Width + 10;


        }

        //private void SetBalloonTip()
        //{
        //    notifyIcon1.Icon = SystemIcons.Exclamation;
        //    notifyIcon1.BalloonTipTitle = "Balloon Tip Title";
        //    notifyIcon1.BalloonTipText = "Balloon Tip Text.";
        //    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
        //    this.Click += new EventHandler(Form1_Click);
        //}

        //void Form1_Click(object sender, EventArgs e)
        //{
        //    notifyIcon1.Visible = true;
        //    notifyIcon1.ShowBalloonTip(30000);

        //}

        private void button4_Click(object sender, EventArgs e)
        {

        }

    

        private void btnBaloonTip_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = "Detta är ett Balloon Tip Title";
            notifyIcon1.BalloonTipText = "Balloon Tip Text.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toolTip1.Active = true;
            toolTip1.Show("Hello", smileyoskar, 2000);
        }
    }
}
