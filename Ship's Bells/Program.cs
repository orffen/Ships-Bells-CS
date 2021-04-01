using System;
using System.Threading;
using System.Windows.Forms;

namespace Ships_Bells
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static Mutex mutexShipsBells;

        [STAThread]
        static void Main()
        {
            if (Program.IsSingleInstance())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                new MainWindow();
                Application.Run();
            }
        }

        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("mutexShipsBells");
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                Program.mutexShipsBells = new Mutex(true, "mutexShipsBells");
                return true;
            }
            return false;
        }
    }
}
