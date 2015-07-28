using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Logic
{
    public class FeedBibliotek
    {
        public List<Feed> Feed { get; set; }

        public string FeedBibliotekTitel { get; set; }

        public int UppdateringsIntervall { get; set; }

        public string RSSUrl { get; set; }

        public int Antal
        {
            get { return Feed.Count; }
        }

        public FeedBibliotek()
        {
            Feed = new List<Feed>();
        }

        public void LäggTillPodcast(Feed f)
        {
            Feed.Add(f);
        }
    }
}
