using System;
using System.Windows.Forms;

namespace Ships_Bells
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += StrikeTheBell;
            timer.Interval = 1000;
            timer.Start();
        }

        private void StrikeTheBell(object sender, EventArgs e)
        {
            if ((DateTime.Now.Minute == 0 || DateTime.Now.Minute == 30) && DateTime.Now.Second == 0)
            {
                BellRinger bellRinger = new BellRinger();
                labelBells.Text = bellRinger.label;
                notifyIcon.Text = bellRinger.label;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = Application.OpenForms["AboutWindow"];
            if (aboutForm == null)
            {
                new AboutWindow().Show();
            }
            else
            {
                aboutForm.BringToFront();
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void ShowWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Activate();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }
    }
}
