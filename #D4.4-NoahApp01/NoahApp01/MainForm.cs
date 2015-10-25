/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2015-01-31
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NoahApp01
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		  
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			string address = "http://www.google.com";
			webBrowser1.Navigate(new Uri(address));
			textBox1.Text = address;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show  ("Hej Noah vill du lära dig programera mer");
		  
		  
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (progressBar1.Value == 100)
		    {
		    	MessageBox.Show ("Den är full(;");
		    }
			if (progressBar1.Value < 100)
			{
			  progressBar1.Value +=10;
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (progressBar1.Value == 0)
			{
				MessageBox.Show (" Den är tom(;");
				
			}
			if (progressBar1.Value > 0)
			{
				progressBar1.Value -=10;
            }
	  }
   }
}