using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using System.Threading;

namespace Project_Lmao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Welcome to 0xetb's free spoofer";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Made by 0xetb";
            notifyIcon1.BalloonTipText = "Enjoy Spoofing Skids";
            notifyIcon1.ShowBalloonTip(10);
            if (!IsAdministrator())
            {
                MessageBox.Show("Please run this application as an administrator.", "Administrator Privileges Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(2000);
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Key is 'free'";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Key is 'free'";
            notifyIcon1.BalloonTipText = "Enjoy Spoofing Skids";
            notifyIcon1.ShowBalloonTip(10);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            if (text == "free")
            {
                Spoof spoof = new Spoof();
                this.Hide();
                spoof.Show();
            }
        }
        private bool IsAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }
}
