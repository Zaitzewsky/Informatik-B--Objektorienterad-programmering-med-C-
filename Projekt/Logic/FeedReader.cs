using System;
using System.ComponentModel;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using Data;
using WMPLib;

namespace Logic
{
    public class FeedReader
    {
        private BibliotekHanterare bibliotekHanterare;
        private Hämtning hämtning;
        private FeedBibliotek senasteTillagdaBibliotek;
        private TimerInitializer senasteTillagdaTimer;
        private ValideringUrlLäggTillPodcast validering;
        private FeedBibliotek feedBibliotekFörAttLaddaOm;

        private string podcastTitel;
        private string listaTitel;
        private string description;
        private int setTimer;
        private int uppdateringsIntervall;
        private string url;
        public FeedReader()
        {
            hämtning = new Hämtning();
            bibliotekHanterare = new BibliotekHanterare();
            validering = new ValideringUrlLäggTillPodcast();
        }

        /// <summary>
        /// Skapar ett nytt feedbibliotek. Skapar nya Feed-objekt beroende på hur många avsnitt angiven RSS-feed har.
        /// Lägger till dessa Feed-objekt i det nyskapade feedbiblioteket.
        /// </summary>
        /// <param name="cbIntervall"></param>
        /// <param name="inUrl"></param>
        /// <returns></returns>
        public FeedBibliotek SkapaFeed(ComboBox cbIntervall, string inUrl)
        {
            XmlNodeList podcastItems = hämtning.LaddaPodcasts(inUrl, "//item");

            FeedBibliotek bibliotek = new FeedBibliotek();

            bibliotek.RSSUrl = inUrl;

            for (int i = 0; i < podcastItems.Count; i++)
            {
                Feed feed = new Feed();

                podcastTitel = Convert.ToString(podcastItems[i].SelectSingleNode("title").InnerText); //Titeln på varje avsnitt.
                inUrl = Convert.ToString(podcastItems[i].SelectSingleNode("enclosure").Attributes["url"].Value); //URL på varje avsnitt.
                description = Convert.ToString(podcastItems[i].SelectSingleNode("description").InnerText); //Beskrivning på varje avsnitt.

                string nyDescription = WebUtility.HtmlDecode(description); //Snyggar upp eventuell HTML-formatering i beskrivningen.

                string trimmedTitel = podcastTitel.Trim('\t', '\n', '\v', '\f', '\r', '"'); //Ser till så att titeln inte innehåller onödiga tecken.

                feed.Title = trimmedTitel;
                feed.Url = inUrl;
                feed.Description = nyDescription;

                //Nedan så kollar koden vilken tid användaren valt och anger en int-variabel med motsvarande tid i millisekunder.
                if (cbIntervall.SelectedIndex == 0)
                {
                    uppdateringsIntervall = 5400000; //90 minuter.
                }
                if (cbIntervall.SelectedIndex == 1)
                {
                    uppdateringsIntervall = 10800000; //180 minuter.
                }
                if (cbIntervall.SelectedIndex == 2)
                {
                    uppdateringsIntervall = 21600000; //360 minuter.
                }

                bibliotek.UppdateringsIntervall = uppdateringsIntervall;
                bibliotek.LäggTillPodcast(feed);

            }
            return bibliotek;
        }

        /// <summary>
        /// Skapar ett feedbibliotek basererat på det som är angett i parameterlistan. Skapar nya Feed-objekt beroende på hur många avsnitt angiven RSS-feed har.
        /// Lägger till dessa Feed-objekt i feedbiblioteket. Väldigt lik metoden ovan.
        /// </summary>
        /// <param name="feedBibliotek"></param>
        /// <param name="inUrl"></param>
        /// <returns></returns>
        public FeedBibliotek LaddaOmBibliotek(FeedBibliotek feedBibliotek, string inUrl)
        {
            XmlNodeList podcastItems = hämtning.LaddaPodcasts(inUrl, "//item");

            FeedBibliotek bibliotek = feedBibliotek;

            for (int i = 0; i < podcastItems.Count; i++)
            {
                Feed feed = new Feed();

                podcastTitel = Convert.ToString(podcastItems[i].SelectSingleNode("title").InnerText);
                inUrl = Convert.ToString(podcastItems[i].SelectSingleNode("enclosure").Attributes["url"].Value);
                description = Convert.ToString(podcastItems[i].SelectSingleNode("description").InnerText);

                string nyDescription = WebUtility.HtmlDecode(description);

                string trimmedTitel = podcastTitel.Trim('\t', '\n', '\v', '\f', '\r', '"');

                feed.Title = trimmedTitel;
                feed.Url = inUrl;
                feed.Description = nyDescription;

                bibliotek.LäggTillPodcast(feed);

            }
            return bibliotek;
        }

        /// <summary>
        /// Loopar igenom angett samlingsbibliotek och kategoribibliotek och
        /// kollar om det finns några feedbibliotek i eventuella kategoribibliotek. Om det finns några feedbibliotek
        /// så instansieras nya timer-objekt baserat på dessa feedbiblioteks angivna uppdateringsintervall.
        /// </summary>
        /// <param name="inSamlingsBibliotek"></param>
        public void InstansieraTimers(SamlingsBibliotek inSamlingsBibliotek)
        {
            SamlingsBibliotek samlingsBibliotek = inSamlingsBibliotek;

            for (int i = 0; i < samlingsBibliotek.Antal; i++)
            {
                for (int j = 0; j < samlingsBibliotek.SamlingsLista.Count; j++)
                {
                    if (samlingsBibliotek.SamlingsLista[i].Antal != 0 && j < samlingsBibliotek.SamlingsLista[i].Antal)
                    {
                        TimerInitializer nyTimer = new TimerInitializer(this, samlingsBibliotek.SamlingsLista[i].KategoriLista[j].RSSUrl, samlingsBibliotek);

                        int tid;

                        tid = samlingsBibliotek.SamlingsLista[i].KategoriLista[j].UppdateringsIntervall;

                        nyTimer.Start(tid);
                        TimerBibliotek.LäggTillTimer(nyTimer);
                    }
                }
            }
        }

        /// <summary>
        /// Loopar igenom RSS-feeden och hämtar titeln på podcastprogrammet.
        /// Sätter angivet feedbiblioteks titel med den hämtade titeln.
        /// </summary>
        /// <param name="inUrl"></param>
        /// <param name="bibliotek"></param>
        /// <param name="samlingsBibliotek"></param>
        public void InstansieraPodcastTitel(string inUrl, FeedBibliotek bibliotek, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                XmlNodeList feedTitle = hämtning.LaddaPodcasts(inUrl, "//channel");

                for (int j = 0; j < feedTitle.Count; j++)
                {
                    listaTitel = Convert.ToString(feedTitle[j].SelectSingleNode("title").InnerText);
                    bibliotek.FeedBibliotekTitel = listaTitel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Skapar ett feedbibliotek, laddar ner tillhörande mp3-filer, sätter titeln på feedbiblioteket,
        /// lägger till feedbiblioteket i vald kategorilista, initialiserar ett nytt timer-objekt
        /// och lägger till det i timerbiblioteket.
        /// </summary>
        /// <param name="inUrl"></param>
        /// <param name="kategori"></param>
        /// <param name="intervall"></param>
        /// <param name="samlingsBibliotek"></param>
        public void SkapaPrenumeration(TextBox inUrl, ComboBox kategori, ComboBox intervall, SamlingsBibliotek samlingsBibliotek)
        {
            string nyUrl = inUrl.Text;
            FeedBibliotek bibliotek = SkapaFeed(intervall, nyUrl);
            PodcastNerladdning(nyUrl);
            
            InstansieraPodcastTitel(nyUrl, bibliotek, samlingsBibliotek);
            bibliotekHanterare.LäggTillFeedBibliotekTillKategoriLista(kategori, bibliotek, samlingsBibliotek);
            
            TimerInitializer timer = new TimerInitializer(this, nyUrl, samlingsBibliotek);

            timer.TimerID = bibliotek.FeedBibliotekTitel;
            timer.Start(bibliotek.UppdateringsIntervall);
            TimerBibliotek.LäggTillTimer(timer);

            senasteTillagdaTimer = timer;
            url = nyUrl;
        }

        /// <summary>
        /// Tömmer angivet feedbibliotek på feed-objekt och lägger in nya feed-objekt.
        /// </summary>
        /// <param name="inUrl"></param>
        /// <param name="samlingsBibliotek"></param>
        public void LaddaOmPrenumeration(string inUrl, SamlingsBibliotek samlingsBibliotek)
        {
            url = inUrl;

            for (int i = 0; i < samlingsBibliotek.Antal; i++)
            {
                for (int j = 0; j < samlingsBibliotek.SamlingsLista[i].Antal; j++)
                {
                    if (samlingsBibliotek.SamlingsLista[i].KategoriLista[j].RSSUrl == url)
                    {
                        feedBibliotekFörAttLaddaOm = samlingsBibliotek.SamlingsLista[i].KategoriLista[j];
                    }
                }
            }

            feedBibliotekFörAttLaddaOm.Feed.Clear();
            feedBibliotekFörAttLaddaOm = LaddaOmBibliotek(feedBibliotekFörAttLaddaOm, url);
        }

        /// <summary>
        /// Loopar igenom listan av xml-noderna "items" i RSS-feeden och laddar ner hittade mp3-filer.
        /// </summary>
        /// <param name="inUrl"></param>
        private void PodcastNerladdning(string inUrl)
        {
            try
            {
                XmlNodeList items = hämtning.LaddaPodcasts(inUrl, "//item");

                //This loops through the list and writes out the title and URL.
                for (int i = 0; i < items.Count; i++)
                {
                    podcastTitel = Convert.ToString(items[i].SelectSingleNode("title").InnerText); //Titeln på mp3-filen.
                    url = Convert.ToString(items[i].SelectSingleNode("enclosure").Attributes["url"].Value); //URLen på mp3-filen.

                    string trimmedTitel = podcastTitel.Trim('\t', '\n', '\v', '\f', '\r', '"'); //Ser till så att titeln inte innehåller onödiga tecken.

                    hämtning.LaddaNerMp3(url, trimmedTitel); //Laddar ner mp3-filer.
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
