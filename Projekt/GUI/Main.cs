using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Repository;
using WMPLib;
using Logic;

namespace GUI
{
    public partial class Main : Form
    {
        private Player player;
        private GUIHanterare guiHanterare;
        private SamlingsBibliotek samlingsBibliotek;
        private ValideringInData validering;
        private Repository repository;
        private FeedReader reader;
        public Main()
        {
            InitializeComponent();
            repository = new Repository();
            reader = new FeedReader();

            samlingsBibliotek = repository.Load();
            guiHanterare = new GUIHanterare();
            validering = new ValideringInData();

            uppdateraKategorier();
            reader.InstansieraTimers(samlingsBibliotek);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    player = new Player();
                    player.SpelaUppMp3(lbPodcasts, cbKategorier, cbPodcasts, samlingsBibliotek);

                    guiHanterare.VisaSomLyssnad(cbKategorier, cbPodcasts, lbPodcasts, samlingsBibliotek);
                    guiHanterare.PrintaPods(cbPodcasts, cbKategorier, lbPodcasts, samlingsBibliotek);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isValidData()
        {
            if (!validering.IsSelected(lbPodcasts))
            {
                return false;
            }

            return true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.StopMp3();
        }

        private void btnLäggTillPodcast_Click(object sender, EventArgs e)
        {
            LäggTillPodcast podcast = new LäggTillPodcast(samlingsBibliotek, this);
            podcast.Show();
        }

        private void btnLäggTillKategori_Click(object sender, EventArgs e)
        {
            LäggTillKategori kategori = new LäggTillKategori(samlingsBibliotek, this);
            kategori.Show();
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            TaBortPodcast taBort = new TaBortPodcast(samlingsBibliotek, this);
            taBort.Show();
        }

        private void btnÄndraKategori_Click(object sender, EventArgs e)
        {
            ÄndraKategori ändra = new ÄndraKategori(samlingsBibliotek, this);
            ändra.Show();
        }

        private void cbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiHanterare.PrintaTitlar(cbKategorier, cbPodcasts, samlingsBibliotek);
        }

        public void uppdateraKategorier()
        {
            lbPodcasts.Items.Clear();
            cbPodcasts.Items.Clear();
            guiHanterare.UppdateraKategoriComboBox(cbKategorier, samlingsBibliotek);
        }

        private void cbPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiHanterare.PrintaPods(cbPodcasts, cbKategorier, lbPodcasts, samlingsBibliotek);
        }

        private void btnÄndraPodcast_Click(object sender, EventArgs e)
        {
            ÄndraPodcast podcast = new ÄndraPodcast(samlingsBibliotek, this);
            podcast.Show();
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            TaBortKategori kategori = new TaBortKategori(samlingsBibliotek, this);
            kategori.Show();
        }

        private void btnBeskrivning_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    guiHanterare.VisaBeskrivning(cbKategorier, cbPodcasts, lbPodcasts, samlingsBibliotek);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                repository.Save(samlingsBibliotek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
