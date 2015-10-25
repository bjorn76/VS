using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PC_AlarmClock
{
    public partial class Form1 : Form
    {
        bool timeup=false;
        int duration = 0,ticks=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1min_Click(object sender, EventArgs e)
        {
            duration = 60; //secs
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            lblCountdown.Text = duration.ToString();
            if (duration == ticks) timeup = true;
            if(timeup) Microsoft.VisualBasic.Interaction.Beep();
            
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
           timer1.Stop();
           duration = 0;
           ticks = 0;
           timeup = false;
        }

        private void button2min_Click(object sender, EventArgs e)
        {
            duration = 60*2; //secs
            timer1.Start();
        }

        private void button3min_Click(object sender, EventArgs e)
        {
            duration = 60*3; //secs
            timer1.Start();
        }

        private void button4min_Click(object sender, EventArgs e)
        {
            duration = 60*4; //secs
            timer1.Start();
        }

        private void button5min_Click(object sender, EventArgs e)
        {
            duration = 60*5; //secs
            timer1.Start();
        }

        private void button10min_Click(object sender, EventArgs e)
        {
            duration = 60*10; //secs
            timer1.Start();
        }
         

        private void button45_Click(object sender, EventArgs e)
        {
            duration = 60 * 45; //secs
            timer1.Start();
        }

        private void button15min_Click(object sender, EventArgs e)
        {
            duration = 60 * 15; //secs
            timer1.Start();
        }

        private void button20min_Click(object sender, EventArgs e)
        {
            duration = 60 * 20; //secs
            timer1.Start();
        }

        private void button30min_Click(object sender, EventArgs e)
        {
            duration = 60 * 30; //secs
            timer1.Start();
        }

        private void button45min_Click(object sender, EventArgs e)
        {
            duration = 60 * 45; //secs
            timer1.Start();
        }

             
    }
}