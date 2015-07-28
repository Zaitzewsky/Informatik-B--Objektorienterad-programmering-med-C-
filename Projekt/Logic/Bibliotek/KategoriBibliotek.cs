using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class KategoriBibliotek
    {
        public List<FeedBibliotek> KategoriLista { get; set; }

        public string KategoriTitel { get; set; }

        public int Antal
        {
            get { return KategoriLista.Count; }
        }

        public KategoriBibliotek()
        {
            KategoriLista = new List<FeedBibliotek>();
        }

        public void LäggTillFeed(FeedBibliotek f)
        {
            KategoriLista.Add(f);
        }
    }
}
