using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class GUIHanterare
    {
        private ValideringPlayknapp validering;
        public GUIHanterare()
        {
            validering = new ValideringPlayknapp();
        }

        /// <summary>
        /// Kollar vilken kategori, podcast och avsnitt som är valt. Validerar om man redan har markerat låten i listan som lyssnad.
        /// Om den inte är lyssnad så blir den markerad, annars så låter den varas.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="avsnitt"></param>
        /// <param name="samlingsBibliotek"></param>
        public void VisaSomLyssnad(ComboBox kategori, ComboBox podcast, ListBox avsnitt,
            SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int kategoriIndex = kategori.SelectedIndex;
                int podcastIndex = podcast.SelectedIndex;
                int avsnittsIndex = avsnitt.SelectedIndex;

                KategoriBibliotek kBibliotek = samlingsBibliotek.SamlingsLista[kategoriIndex];
                FeedBibliotek fBibliotek = kBibliotek.KategoriLista[podcastIndex];

                validering.isListened(fBibliotek, avsnittsIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Kollar vilken kategori, podcast och avsnitt man valt och startar en MessageBox med innehållet från egenskapen "Description" i feedbiblioteket.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="podcast"></param>
        /// <param name="avsnitt"></param>
        /// <param name="samlingsBibliotek"></param>
        public void VisaBeskrivning(ComboBox kategori, ComboBox podcast, ListBox avsnitt,
            SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                int kategoriIndex = kategori.SelectedIndex;
                int podcastIndex = podcast.SelectedIndex;
                int avsnittsIndex = avsnitt.SelectedIndex;

                KategoriBibliotek kBibliotek = samlingsBibliotek.SamlingsLista[kategoriIndex];
                FeedBibliotek fBibliotek = kBibliotek.KategoriLista[podcastIndex];

                MessageBox.Show(fBibliotek.Feed[avsnittsIndex].Description, "Beskrivning");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Sätter in alla värden från intervallbiblioteket i angiven combobox.
        /// </summary>
        /// <param name="intervall"></param>
        /// <param name="intervallBibliotek"></param>
        public void PrintaIntervaller(ComboBox intervall, IntervallBibliotek intervallBibliotek)
        {
            try
            {
                intervall.Items.Clear();

                for (int i = 0; i < intervallBibliotek.Antal; i++)
                {
                    intervall.Items.Add(intervallBibliotek.Intervall[i] + " minuter");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fyller på angiven combobox med podcasttitlar.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="titlar"></param>
        /// <param name="samlingsBibliotek"></param>
        public void PrintaTitlar(ComboBox kategori, ComboBox titlar, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                titlar.Items.Clear();

                int index = kategori.SelectedIndex;

                KategoriBibliotek bibliotek = samlingsBibliotek.SamlingsLista[index];

                for (int i = 0; i < bibliotek.Antal; i++)
                {
                    titlar.Items.Add(bibliotek.KategoriLista[i].FeedBibliotekTitel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fyller på angiven listbox med avsnitt, baserat på vald kategori och podcast.
        /// </summary>
        /// <param name="titel"></param>
        /// <param name="kategori"></param>
        /// <param name="lb"></param>
        /// <param name="samlingsBibliotek"></param>
        public void PrintaPods(ComboBox titel, ComboBox kategori, ListBox lb, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                lb.Items.Clear();

                int index = titel.SelectedIndex;

                int j = kategori.SelectedIndex;

                KategoriBibliotek Kbibliotek = samlingsBibliotek.SamlingsLista[j];

                FeedBibliotek Fbibliotek = Kbibliotek.KategoriLista[index];

                for (int i = 0; i < Fbibliotek.Antal; i++)
                {
                    lb.Items.Add(Fbibliotek.Feed[i].Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fyller på angiven combobox med kategorititlar.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="samlingsBibliotek"></param>
        public void UppdateraKategoriComboBox(ComboBox kategori, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                kategori.Items.Clear();

                for (int i = 0; i < samlingsBibliotek.Antal; i++)
                {
                    kategori.Items.Add(samlingsBibliotek.SamlingsLista[i].KategoriTitel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fyller på angivna comboxar med kategorititlar.
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="nyKategori"></param>
        /// <param name="samlingsBibliotek"></param>
        public void UppdateraKategoriComboBox(ComboBox kategori, ComboBox nyKategori, SamlingsBibliotek samlingsBibliotek)
        {
            try
            {
                kategori.Items.Clear();

                for (int i = 0; i < samlingsBibliotek.Antal; i++)
                {
                    kategori.Items.Add(samlingsBibliotek.SamlingsLista[i].KategoriTitel);
                    nyKategori.Items.Add(samlingsBibliotek.SamlingsLista[i].KategoriTitel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
