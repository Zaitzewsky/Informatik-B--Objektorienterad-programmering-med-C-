using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SamlingsBibliotek
    {
        public List<KategoriBibliotek> SamlingsLista { get; set; }

        public int Antal
        {
            get { return SamlingsLista.Count; }
        }

        public SamlingsBibliotek()
        {
            SamlingsLista = new List<KategoriBibliotek>();
        }

        public void LäggTillKategori(KategoriBibliotek k)
        {
            SamlingsLista.Add(k);
        }
    }
}
