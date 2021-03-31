using System;
using System.Windows.Forms;

namespace Ships_Bells
{
    public partial class MainWindow : Form
    {
        private static System.Timers.Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            timer = new System.Timers.Timer();
            timer.SynchronizingObject = this;
            timer.Elapsed += StrikeTheBell;
            timer.Interval = GetInterval();
            timer.Start();
        }

        private void StrikeTheBell(object sender, EventArgs e)
        {
            BellRinger bellRinger = new BellRinger();
            labelBells.Text = bellRinger.label;
            notifyIcon.Text = bellRinger.label;
            timer.Stop();
            timer.Interval = GetInterval();
            timer.Start();
        }

        private int GetInterval()
        {
            DateTime now = DateTime.Now;
            int minutes = (59 - now.Minute) % 30;
            int seconds = 59 - now.Second;
            int milliseconds = 1000 - now.Millisecond;
            return (minutes * 60 * 1000) + (seconds * 1000) + milliseconds;
        }

        private void ShowWindow()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Activate();
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
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position);
            }
            else
            {
                ShowWindow();
            }
        }
    }
}
