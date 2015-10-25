/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2011-05-28
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace KaffET
{
	
	public sealed class SingletonNotificationIcon
	{

		private static SingletonNotificationIcon instance = new SingletonNotificationIcon(); //BNJ
		public static SingletonNotificationIcon Instance {
			get {return instance;}
		}
				
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		
		private  Alarm alarmKaffET;
		
		public Alarm AlarmKaffET {
			get { return alarmKaffET; }
			set { alarmKaffET = value; }
		}
	
		
				
		#region Initialize icon and menu
		public SingletonNotificationIcon()
		{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingletonNotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("clock"); 
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("About", menuAboutClick),
				new MenuItem("Test", menuTestClick),
				new MenuItem("KaffET", menuKaffETClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "KaffET", out isFirstInstance)) {
				if (isFirstInstance) {
					
					SingletonNotificationIcon.Instance.notifyIcon.Visible = true;
					SingletonNotificationIcon.Instance.AlarmKaffET = new Alarm();
					Application.Run();
					//Application.Run(new Form2()); //BNJ
					//NotificationIcon.frmKaffET.Show; //BNJ
					
					//notificationIcon.notifyIcon.Dispose();
					SingletonNotificationIcon.Instance.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		//Application.Run(new Form1());
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("About This Application");
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show("The icon was double clicked");
		}
		//private void Icon(object sender, EventArgs e)
		private void menuTestClick(object sender, EventArgs e)
		{
			Form2 tForm2 = new Form2(); //BNJ
			tForm2.Show(); //BNJ
			//SingletonNotificationIcon.Instance.FrmControl.Show();
		}
		
		
		private void menuKaffETClick(object sender, EventArgs e)
		{
			FrmKaffETalarm fka = new FrmKaffETalarm();
			fka.Visible=true;
		}
		
	}
		#endregion
	
}
