using System;
using System.Threading;

namespace Ships_Bells
{
    class BellRinger
    {
        private static System.Media.SoundPlayer oneBell = new System.Media.SoundPlayer(Properties.Resources.tang);
        private static System.Media.SoundPlayer twoBells = new System.Media.SoundPlayer(Properties.Resources.tangtang);

        private static String[] watchNames = { "First", "Middle", "Morning", "Forenoon", "Afternoon", "First Dog", "Second Dog" };
        private static String[] bellNames = { "no?!?!?", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight" };

        public int watch;
        public int numberOfBells;
        public String label;

        public BellRinger()
        {
            watch = DetermineWatch();
            numberOfBells = DetermineBells();
            label = Display();
            Thread thread = new Thread(Ring) { IsBackground = true };
            thread.Start();
        }

        private int DetermineWatch()
        {
            int minutes = DateTime.Now.Minute;
            int w = DateTime.Now.Hour * 2;
            if (minutes >= 45)
            {
                w += 2;
            }
            else if (minutes > 15)
            {
                w += 1;
            }
            return w;
        }

        private int DetermineWatchName()
        {
            int w = watch % 48;
            if (w == 0)
            {
                return 0;
            }
            else if (w <= 8)
            {
                return 1;
            }
            else if (w <= 16)
            {
                return 2;
            }
            else if (w <= 24)
            {
                return 3;
            }
            else if (w <= 32)
            {
                return 4;
            }
            else if (w <= 36)
            {
                return 5;
            }
            else if (w <= 40)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        private int DetermineBells()
        {
            if (watch == 39)
            {
                return 3;
            }
            else if (watch == 38)
            {
                return 2;
            }
            else if (watch == 37)
            {
                return 1;
            }
            int b = watch % 8;
            if (b == 0)
            {
                b = 8;
            }
            return b;
        }

        private String Display()
        {
            String disp = (bellNames[numberOfBells] + " bell"
                + (numberOfBells == 1 ? "" : "s") + " in the "
                + watchNames[DetermineWatchName()] + " Watch.");
            return disp;
        }

        private void Ring()
        {
            int b = numberOfBells;
            while (b > 0)
            {
                if (b >= 2)
                {
                    twoBells.PlaySync();
                    b -= 2;
                }
                else
                {
                    oneBell.PlaySync();
                    b -= 1;
                }
            }
        }
    }
}
