using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class ValideringUrlLäggTillPodcast
    {
        private SamlingsBibliotek samlingsBibliotek;

        /// <summary>
        /// Loopar igenom angivet samlingsbibliotek, kategoribibliotek och feedbibliotek för att jämföra den URL
        /// som användaren angett som adress till podcastens RSS-feed. Om URLen redan finns så visas en messagebox
        /// som berättar för användaren att denne inte kan lägga till denna podcast.
        /// </summary>
        /// <param name="txtUrl"></param>
        /// <param name="inSamlingsBibliotek"></param>
        /// <returns></returns>
        public bool UrlAlreadyExist(TextBox  txtUrl, SamlingsBibliotek inSamlingsBibliotek)
        {
            string url = txtUrl.Text;

            samlingsBibliotek = inSamlingsBibliotek;

            for (int i = 0; i < samlingsBibliotek.Antal; i++)
            {
                for (int j = 0; j < samlingsBibliotek.SamlingsLista[i].Antal; j++)
                {
                    for (int h = 0; h < samlingsBibliotek.SamlingsLista[i].KategoriLista[j].Antal; h++)
                    {
                        if (samlingsBibliotek.SamlingsLista[i].KategoriLista[j].RSSUrl == url)
                        {
                            MessageBox.Show("Denna podcast har redan lagts till!", "Error");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
