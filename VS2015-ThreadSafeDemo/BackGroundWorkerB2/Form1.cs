using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace bgwB2
{
    public partial class Form1 : Form
    {
        // This BackgroundWorker is used to demonstrate the 
        // preferred way of performing asynchronous operations.


        private string rText="", rText2="";

            public Form1()
            {
                InitializeComponent();
            }

 
            private void setTextBackgroundWorkerBtn_Click(
                object sender,
                EventArgs e)
            {
                this.bgw1.RunWorkerAsync();
                this.bgw2.RunWorkerAsync();

        }

        // This event handler sets the Text property of the TextBox
        // control. It is called on the thread that created the 
        // TextBox control, so the call is thread-safe.
        //
        // BackgroundWorker is the preferred way to perform asynchronous
        // operations.

        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            for (int i= 0; i <= 4; i++)
            {
                rText +=  i.ToString() + Environment.NewLine;
                bgw1.ReportProgress((i+1)*25);
            }
            rText += "bgw1_dowork" + Environment.NewLine; ;


        }
        private void bgw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            rText += "bgw1 progress: "+ e.ProgressPercentage.ToString() + Environment.NewLine;


        }



        private void bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
            this.textBox1.AppendText(rText);
            rText = "";
            this.textBox1.AppendText( "#SafelyByBackgroundWorkerCompleted."+ Environment.NewLine);
            
        }

 

        private void bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            rText2 += "#BGW2" + Environment.NewLine;
        }

  

        private void bgw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.textBox1.AppendText(rText2);
            rText2 = "";
            this.textBox1.AppendText("#bgw_Completed." + Environment.NewLine);

        }


    }

}

