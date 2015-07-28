using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Logic
{
    public class Player
    {
        private FeedReader reader;
        private WindowsMediaPlayer wplayer;
        private string url;
        private FeedBibliotek bibliotek;
        public Player()
        {
            wplayer = new WindowsMediaPlayer();
        }

        /// <summary>
        /// Spelar upp mp3-fil baserat på vilken kategori, podcast och avsnitt man valt. Tar bort eventuella asterixer på avsnittsnamnen för att
        /// matcha med mp3-filen.
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="samlingsBibliotek"></param>
        public void SpelaUppMp3(ListBox lb, ComboBox kategori, ComboBox podcast, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int index = lb.SelectedIndex;

                int kategoriIndex = kategori.SelectedIndex;

                int podcastIndex = podcast.SelectedIndex;

                KategoriBibliotek kBibliotek = samlingsBibliotek.SamlingsLista[kategoriIndex];

                FeedBibliotek fBibliotek = kBibliotek.KategoriLista[podcastIndex];

                string titel = fBibliotek.Feed[index].Title;

                string trimmedTitel = titel.Trim('*');

                wplayer.URL = trimmedTitel + ".mp3";
                wplayer.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Stoppar spelande mp3.
        /// </summary>
        public void StopMp3()
        {
            try
            {
                wplayer.controls.stop();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
