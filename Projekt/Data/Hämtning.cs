using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Data
{
    public class Hämtning
    {
        public Hämtning()
        {
            
        }

        public void LaddaNerMp3(string url, string filepath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(url), filepath + ".mp3");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public XmlNodeList LaddaPodcasts(string url, string nodes)
        {
                //Denna laddar podcasten
                XmlDocument doc = new XmlDocument();
                doc.Load(url);

                //Denna bygger en lista av items
                XmlNodeList items = doc.SelectNodes(nodes);
                return items;
        }
    }
}
