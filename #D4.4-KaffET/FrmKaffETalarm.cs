/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2011-05-29
 * Time: 18:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KaffET
{
	/// <summary>
	/// Description of FrmKaffETalarm.
	/// </summary>
	public partial class FrmKaffETalarm : Form
	{
		public FrmKaffETalarm()
		{
			
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			// TODO: Add constructor code after the InitializeComponent() call.
			timer1.Enabled = true;			
		}
		

		
		void Timer1Tick(object sender, EventArgs e)
		{
		  
		  if (label1.Visible)
			  label1.Visible=false;
		  else
			 label1.Visible=true;
				
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
		  SingletonNotificationIcon.Instance.AlarmKaffET.Stop();
		  this.Close();
		}
	}
}
