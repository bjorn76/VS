/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2011-05-28
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using KaffET;

namespace KaffET
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		bool timeup=false;
        int duration = 0,ticks=0;
		
		public Form2()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			// TODO: Add constructor code after the InitializeComponent() call.
			
		}
				
		
//		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
//		{
// 		    System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
//            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason );
//            messageBoxCS.AppendLine();
//            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel );
//            messageBoxCS.AppendLine();
//            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event" );
//
//			//this.Hide();
// 		    //e.Cancel = true; // this cancels the close event.
//        }
//		
		void Button1Click(object sender, EventArgs e)
		{
			duration = 3; //secs
            timer1.Start();
		}
		
		void StopClick(object sender, EventArgs e)
		{           
		   timer1.Stop();
           duration = 0;
           ticks = 0;
           timeup = false;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
		    duration--;
            lblCountdown.Text = duration.ToString();
            if (duration == ticks) timeup = true;
            if(timeup) Microsoft.VisualBasic.Interaction.Beep();


            
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			SingletonNotificationIcon.Instance.AlarmKaffET.Test();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		  SingletonNotificationIcon.Instance.AlarmKaffET.Stop();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
	        //datetime test	
        	label1.Text= DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()  ;
            
		}
		
	
		
		void Button5Click(object sender, EventArgs e)
		{
			label2.Text=SingletonNotificationIcon.Instance.AlarmKaffET.time();
		}
	}
}
