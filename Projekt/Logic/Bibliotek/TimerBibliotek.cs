using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Logic
{
    public static class TimerBibliotek
    {
        public static List<TimerInitializer> Timer { get ; set; } 

        public static int Antal
        {
            get { return Timer.Count; }
        }

        public static void LäggTillTimer(TimerInitializer timer)
        {
            if (Timer == null)
            {
                Timer = new List<TimerInitializer>();
            }
            Timer.Add(timer);
        }
    }
}
