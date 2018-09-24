using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchWindowsRDPSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Start_Windows_RDP()
        {

            String machine_name = txtMachineName.Text;

            try
            {

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                System.Security.SecureString ssPwd = new System.Security.SecureString();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = "mstsc.exe";
                proc.StartInfo.Arguments = "/v:" + machine_name;
                proc.Start();

            }
            catch
            {

            }



        }

        private void btnRDP_Click(object sender, EventArgs e)
        {
            Start_Windows_RDP();
        }
    }
}

