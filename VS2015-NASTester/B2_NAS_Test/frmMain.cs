using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // frmMain. = "B2_NAS_Test";
           Text = "B2_NAS_Test";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.
            // lbNWPaths.Items.Add( "hfhfh jfjf"); //erDialog1.SelectedPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
              lbNWPaths.Items.Add(folderBrowserDialog1.SelectedPath);

            }
              
            
        }

  
    }
}
