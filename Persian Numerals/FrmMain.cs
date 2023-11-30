using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Persian_Numerals
{
    public partial class FrmMain : Form

    {
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            chkStartup.Checked = Properties.Settings.Default.Startup;
            if (Properties.Settings.Default.Startup)
                rk.SetValue("Persian Numerals", Application.ExecutablePath + " startup");
            else
                rk.DeleteValue("Persian Numerals", false);

        }

        static System.Threading.Mutex singleton = new Mutex(true, "Persian Numerals");
        private IKeyboardMouseEvents m_GlobalHook;

        [DllImport("user32.dll")] static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);
        [DllImport("user32.dll")] static extern IntPtr GetKeyboardLayout(uint thread);

        public CultureInfo GetCurrentKeyboardLayout()
        {
            try
            {
                IntPtr foregroundWindow = GetForegroundWindow();
                uint foregroundProcess = GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
                int keyboardLayout = GetKeyboardLayout(foregroundProcess).ToInt32() & 0xFFFF;
                return new CultureInfo(keyboardLayout);
            }
            catch (Exception)
            {
                return new CultureInfo(1033);
            }
        }

        public FrmMain()
        {


            if (!singleton.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("there is already another instance running!");
                Environment.Exit(0);
            }
            InitializeComponent();
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
            m_GlobalHook.KeyUp += GlobalHookKeyUp;
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }
        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (Properties.Settings.Default.Role == 0 || !Properties.Settings.Default.IsPersian) return;
            if (e.Shift || e.Control || e.Alt) return;


            string[] Persian_numerals = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            if (e.KeyValue > 95 && e.KeyValue < 106 && Properties.Settings.Default.NumLock)
            {

                SendKeys.Send(Persian_numerals[e.KeyValue - 96]);
                e.Handled = true;

            }
            if (e.KeyValue > 47 && e.KeyValue < 58 && Properties.Settings.Default.General)
            {

                SendKeys.Send(Persian_numerals[e.KeyValue - 48]);
                e.Handled = true;

            }

        }
        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (radScrollLock.Checked && e.KeyValue == 145)
            {


                Properties.Settings.Default.IsPersian = !Properties.Settings.Default.IsPersian;
                Properties.Settings.Default.Save();

            }
            if (radCtrlShift.Checked)
            {
                if (e.KeyData.ToString().ToLower().Contains("control") && e.KeyData.ToString().ToLower().Contains("shift"))
                {

                    Properties.Settings.Default.IsPersian = !Properties.Settings.Default.IsPersian;
                    Properties.Settings.Default.Save();

                }
            }

            lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");
        }



        public void Unsubscribe()
        {
            m_GlobalHook.Dispose();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                SetStartup();
            }
            catch (Exception)
            {

            }

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            lblVersion.Text = version;

            if (Properties.Settings.Default.Role == 0) radDisable.Checked = true;
            if (Properties.Settings.Default.Role == 1) radAlways.Checked = true;
            if (Properties.Settings.Default.Role == 2) radScrollLock.Checked = true;
            if (Properties.Settings.Default.Role == 3) radCtrlShift.Checked = true;
            if (Properties.Settings.Default.Role == 4) radOperationLang.Checked = true;

            chkNumLock.Checked = Properties.Settings.Default.NumLock;
            chkGeneral.Checked = Properties.Settings.Default.General;



            if (radScrollLock.Checked)
            {
                Properties.Settings.Default.IsPersian = Control.IsKeyLocked(Keys.Scroll);
                Properties.Settings.Default.Save();
            }

            if (radOperationLang.Checked)
                timer1.Enabled = true;

            lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");
        }


        private void radScrollLock_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = 2;

            Properties.Settings.Default.IsPersian = Control.IsKeyLocked(Keys.Scroll);
            Properties.Settings.Default.Save();

            lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.Role == 4)
            {
                Properties.Settings.Default.IsPersian = GetCurrentKeyboardLayout().DisplayName.ToLower().Contains("persian");
                Properties.Settings.Default.Save();
                lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");
            }
            else
            {
                timer1.Enabled = false;
            }

        }

        private void radCtrlShift_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = 3;
            Properties.Settings.Default.Save();

        }

        private void radAlways_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = 1;
            Properties.Settings.Default.IsPersian = true;

            Properties.Settings.Default.Save();
            lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");

        }

        private void chkNumLock_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNumLock.Checked && !chkGeneral.Checked)
            {
                chkGeneral.Checked = true;
            }
            Properties.Settings.Default.NumLock = chkNumLock.Checked;
            Properties.Settings.Default.General = chkGeneral.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNumLock.Checked && !chkGeneral.Checked)
            {
                chkNumLock.Checked = true;
            }
            Properties.Settings.Default.NumLock = chkNumLock.Checked;
            Properties.Settings.Default.General = chkGeneral.Checked;
            Properties.Settings.Default.Save();
        }

        private void radDisable_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = 0;
            Properties.Settings.Default.IsPersian = false;

            Properties.Settings.Default.Save();
            lblStatus.Text = (Properties.Settings.Default.IsPersian ? "⚫ Active" : "⚫ Deactive");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (!lblStatus.Text.Contains("Deactive"))
            {
                lblStatus.ForeColor = Color.Green;
                notifyIcon1.Icon = Properties.Resources.miniiconper;
                notifyIcon1.Text = "Number keys are Persian";
            }
            else
            {
                lblStatus.ForeColor = Color.Maroon;
                notifyIcon1.Icon = Properties.Resources.miniiconen;
                notifyIcon1.Text = "Number keys are English";
            }
        }



        private void radOperationLang_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = 4;
            Properties.Settings.Default.Save();
            timer1.Enabled = true;
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/vahidvb");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon1.BalloonTipTitle = "Persian Numerals";
            notifyIcon1.BalloonTipText = "Application is running...";

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(500);
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/vahidvb");
        }



        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Startup = chkStartup.Checked;
            Properties.Settings.Default.Save();
            SetStartup();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            String[] arguments = Environment.GetCommandLineArgs();
            foreach (string s in arguments)
            {
                if (s.Equals("startup"))
                {
                    this.Hide();

                }
            }
            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Upon complete exit, the program becomes inactive. Are you sure you want to exit the program?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

    }
}
