/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2011-05-29
 * Time: 08:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;



namespace KaffET
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Alarm
	{
		public bool timeup=false;
        public int duration = 0;
        public int ticks=0;
        public int h=9;
        private int m=30;
                
		
        private Timer atimer = new Timer();
        private FrmKaffETalarm frmKaffET;
        
		public FrmKaffETalarm FrmKaffET {
			
        	get
			{ 
			
				if (frmKaffET == null)
				{
				 	frmKaffET = new FrmKaffETalarm ();
				 	return frmKaffET; 	
			
				}
					
				else 
				 {
				 return frmKaffET;
				 }
			}
		
			
			set { frmKaffET = value; }
		        
        
        
        }
	
        
		public Timer timer {
			get { return atimer; }
			
		}
		//public Timer atimer;
        
		public Alarm()
		{
		  
		  this.atimer.Interval = 1000;
          this.atimer.Tick += new System.EventHandler(this.atimer_Tick);
          		  
		}

        private void atimer_Tick(object sender, EventArgs e)
        {
            duration--;
            //lblCountdown.Text = duration.ToString();
            //if (duration == ticks) timeup = true;
            
            DateTime dtNow = DateTime.Now;
            if ((dtNow.Hour == h) && (dtNow.Minute == m)) timeup = true; //BNJ
                        
            if(timeup) 
            {
             	//Microsoft.VisualBasic.Interaction.Beep();
             	Console.Beep();
             	
             	
             	try
			    {
             		if (FrmKaffET.Visible==false) FrmKaffET.Visible=true;;
             	}
             	
             	catch (ObjectDisposedException Er)
             	{
             		//MessageBox.Show  ("ODisp   " + Er.ToString());
             		SingletonNotificationIcon.Instance.AlarmKaffET.Stop();
             		frmKaffET = new FrmKaffETalarm();
             		
             	}
             	             	
             	catch (Exception Er)
			    {
             		MessageBox.Show (Er.ToString());
             		//frmKaffET = new FrmKaffETalarm();
                } 
             	
            }  
        }
		
	    
        public void Set(int harg,int marg)
        {
        	//DateTime start = DateTime.Now; 
        	h = harg;
        	m = marg;
        	
        }
        
        public void Test()
		{
		  //duration=3;
		  h= DateTime.Now.Hour;
		  m= DateTime.Now.Minute + 1;
		  atimer.Start();
			
		}
		
		public void Stop()
		{           
		   atimer.Stop();
           duration = 0;
           ticks = 0;
           timeup = false;
			
		}
		public string time()
		{
			
			return (h.ToString() + ":" + m.ToString());
		
		}
		}
	
    
    	
    }





