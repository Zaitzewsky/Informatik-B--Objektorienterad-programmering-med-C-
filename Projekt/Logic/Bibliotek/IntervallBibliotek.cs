using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class IntervallBibliotek
    {
        public List<String> Intervall { get; set; }

        public int Antal
        {
            get { return Intervall.Count; }
        }

        public IntervallBibliotek()
        {
            Intervall = new List<String> {"90", "180", "360"};
        }
    }
}
