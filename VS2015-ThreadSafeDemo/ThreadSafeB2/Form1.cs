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


namespace ThreadSafe

//https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(EHInvalidOperation.WinForms.IllegalCrossThreadCall);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)&rd=true
// To make a thread-safe call to a Windows Forms control
// 1.Query the control's InvokeRequired property.
// 2.If InvokeRequired returns true, call Invoke with a delegate that makes the actual call to the control.
// 3.If InvokeRequired returns false, call the control directly


{
    public partial class Form1 : Form
    {
 
            // This delegate enables asynchronous calls for setting
            // the text property on a TextBox control.
            delegate void SetTextCallback(string text);

            // This thread is used to demonstrate both thread-safe and
            // unsafe ways to call a Windows Forms control.
            private Thread demoThread = null;

        // This BackgroundWorker is used to demonstrate the 
        // preferred way of performing asynchronous operations.
        //private BackgroundWorker backgroundWorker1;  //Draged in to form B2

        //private TextBox textBox1;
        //private Button setTextUnsafeBtn;
        //private Button setTextSafeBtn;
        //private Button setTextBackgroundWorkerBtn;

        //private System.ComponentModel.IContainer components = null;

        private string rText;

            public Form1()
            {
                InitializeComponent();
            }

            //protected override void Dispose(bool disposing)
            //{
            //    if (disposing && (components != null))
            //    {
            //        components.Dispose();
            //    }
            //    base.Dispose(disposing);
            //}

            // This event handler creates a thread that calls a 
            // Windows Forms control in an unsafe way.
            private void setTextUnsafeBtn_Click(object sender, EventArgs e)
            {
                this.demoThread =
                    new Thread(new ThreadStart(this.ThreadProcUnsafe));

                this.demoThread.Start();
            }

  

        // This method is executed on the worker thread and makes
        // an unsafe call on the TextBox control.
        private void ThreadProcUnsafe()
            {
                this.textBox1.Text = "This text was set unsafely.";
            }

            // This event handler creates a thread that calls a 
            // Windows Forms control in a thread-safe way.
            private void setTextSafeBtn_Click(
                object sender,
                EventArgs e)
            {
                this.demoThread =
                    new Thread(new ThreadStart(this.ThreadProcSafe));

                this.demoThread.Start();
            }
 

        // This method is executed on the worker thread and makes
        // a thread-safe call on the TextBox control.
        private void ThreadProcSafe()
            {
                this.SetText("This text was set safely.");
            }

            // This method demonstrates a pattern for making thread-safe
            // calls on a Windows Forms control. 
            //
            // If the calling thread is different from the thread that
            // created the TextBox control, this method creates a
            // SetTextCallback and calls itself asynchronously using the
            // Invoke method.
            //
            // If the calling thread is the same as the thread that created
            // the TextBox control, the Text property is set directly. 

            private void SetText(string text)
            {
                // InvokeRequired required compares the thread ID of the
                // calling thread to the thread ID of the creating thread.
                // If these threads are different, it returns true.
                if (this.textBox1.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.textBox1.Text = text;
                }
            }

            // This event handler starts the form's 
            // BackgroundWorker by calling RunWorkerAsync.
            //
            // The Text property of the TextBox control is set
            // when the BackgroundWorker raises the RunWorkerCompleted
            // event.
            private void setTextBackgroundWorkerBtn_Click(
                object sender,
                EventArgs e)
            {
                this.backgroundWorker1.RunWorkerAsync();
            }

            // This event handler sets the Text property of the TextBox
            // control. It is called on the thread that created the 
            // TextBox control, so the call is thread-safe.
            //
            // BackgroundWorker is the preferred way to perform asynchronous
            // operations.

            private void backgroundWorker1_RunWorkerCompleted(
                object sender,
                RunWorkerCompletedEventArgs e)
            {
            this.textBox1.AppendText(rText);
            rText = "";
            this.textBox1.AppendText( "#SafelyByBackgroundWorkerCompleted."+ Environment.NewLine);

            }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
               rText += ("#BackgroundWorker_DoWork. ") +i.ToString()+ Environment.NewLine ;
                Console.Beep(698, 100);
            }
 ;
            
        }


    }
}
