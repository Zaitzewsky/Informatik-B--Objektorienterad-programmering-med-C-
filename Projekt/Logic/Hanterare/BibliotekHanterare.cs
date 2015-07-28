using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Logic
{
    public class BibliotekHanterare
    {

        private int intervalTime;
        private FeedReader reader;
        public BibliotekHanterare()
        {
        }

        /// <summary>
        /// Lägger till ett feedbibliotek i en kategorilista
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="bibliotek"></param>
        /// <param name="samlingsBibliotek"></param>
        public void LäggTillFeedBibliotekTillKategoriLista(ComboBox kategori, FeedBibliotek bibliotek, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = kategori.SelectedIndex;

                KategoriBibliotek bibliotekAvFeeds = samlingsBibliotek.SamlingsLista[index];

                bibliotekAvFeeds.LäggTillFeed(bibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Tar bort ett feedbibliotek, stänger ner det tillhörande timer-objektet.
        /// Lägger till ett exakt likadant feedbibliotek i en kategorilista och startar ett nytt timer-objekt.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="nyKategori"></param>
        /// <param name="samlingsBibliotek"></param>
        public void BytKategori(ComboBox kategori, ComboBox podcast, ComboBox nyKategori,  SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = kategori.SelectedIndex;

                int podcastIndex = podcast.SelectedIndex;

                KategoriBibliotek bibliotekAvFeeds = samlingsBibliotek.SamlingsLista[index];

                FeedBibliotek feedBibliotek = bibliotekAvFeeds.KategoriLista[podcastIndex];

                for (int i = 0; i < TimerBibliotek.Antal; i++)
                {
                    if (TimerBibliotek.Timer[i].TimerID == feedBibliotek.FeedBibliotekTitel)
                    {
                        TimerBibliotek.Timer[i].timer.Close();
                    }
                }

                string url = feedBibliotek.RSSUrl;

                TimerInitializer timer = new TimerInitializer(reader, url, samlingsBibliotek);

                timer.TimerID = feedBibliotek.FeedBibliotekTitel;
                timer.Start(feedBibliotek.UppdateringsIntervall);
                TimerBibliotek.LäggTillTimer(timer);

                LäggTillFeedBibliotekTillKategoriLista(nyKategori, feedBibliotek, samlingsBibliotek);
                TaBortPodcast(kategori, podcast, samlingsBibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Ändrar uppdateringsintervallet på feedblioteket och på tillhörande timerobjekt.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="intervall"></param>
        /// <param name="samlingsBibliotek"></param>
        public void ÄndraUppdateringsIntervall(ComboBox kategori, ComboBox podcast, ComboBox intervall,
            SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = kategori.SelectedIndex;

                int podcastIndex = podcast.SelectedIndex;

                KategoriBibliotek bibliotekAvFeeds = samlingsBibliotek.SamlingsLista[index];

                FeedBibliotek feedBibliotek = bibliotekAvFeeds.KategoriLista[podcastIndex];


                if (intervall.SelectedIndex == 0)
                {
                    intervalTime = 5400000;
                }
                if (intervall.SelectedIndex == 1)
                {
                    intervalTime = 10800000;
                }
                if (intervall.SelectedIndex == 2)
                {
                    intervalTime = 21600000;
                }

                feedBibliotek.UppdateringsIntervall = intervalTime;

                for (int i = 0; i < TimerBibliotek.Antal; i++)
                {
                    if (TimerBibliotek.Timer[i].TimerID == feedBibliotek.FeedBibliotekTitel)
                    {
                        TimerBibliotek.Timer[i].ChangeIntervalTime(intervalTime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Lägger till ett nytt kategoribibliotek i samlingsbiblioteket.
        /// </summary>
        /// <param name="nyKategori"></param>
        /// <param name="samlingsBibliotek"></param>
        public void LäggTillKategoriBibliotekTillSamlingsLista(TextBox nyKategori, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                string kategoriNamn = nyKategori.Text;

                KategoriBibliotek bibliotek = new KategoriBibliotek();

                bibliotek.KategoriTitel = kategoriNamn;

                samlingsBibliotek.LäggTillKategori(bibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Kollar vilken kategori som är vald i comboboxen och ändrar det kategoribibliotekets titel.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="nyttKategoriNamn"></param>
        /// <param name="samlingsBibliotek"></param>
        public void ÄndraKategoriNamn(ComboBox kategori, TextBox nyttKategoriNamn, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                string kategoriNamn = nyttKategoriNamn.Text;

                int index = kategori.SelectedIndex;

                KategoriBibliotek bibliotek = samlingsBibliotek.SamlingsLista[index];

                bibliotek.KategoriTitel = kategoriNamn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Kollar vilken kategori och podcast man valt och stänger tillhörande timer-objekt och tar bort vald podcast från kategorilistan.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="samlingsBibliotek"></param>
        public void TaBortPodcast(ComboBox kategori, ComboBox podcast, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = podcast.SelectedIndex;

                int j = kategori.SelectedIndex;

                KategoriBibliotek Kbibliotek = samlingsBibliotek.SamlingsLista[j];

                FeedBibliotek Fbibliotek = Kbibliotek.KategoriLista[index];

                for (int i = 0; i < TimerBibliotek.Antal; i++)
                {
                    if (TimerBibliotek.Timer[i].TimerID == Fbibliotek.FeedBibliotekTitel)
                    {
                        TimerBibliotek.Timer[i].timer.Close();
                    }
                }

                Kbibliotek.KategoriLista.Remove(Fbibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Tar bort vald kateogri ur samlingsbiblioteket och stänger ner tillhörande timer-objekt.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="samlingsBibliotek"></param>
        public void TaBortKategori(ComboBox kategori, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = kategori.SelectedIndex;

                KategoriBibliotek bibliotek = samlingsBibliotek.SamlingsLista[index];

                for (int i = 0; i < TimerBibliotek.Antal; i++)
                {
                    TimerBibliotek.Timer[i].timer.Close();
                }

                samlingsBibliotek.SamlingsLista.Remove(bibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
