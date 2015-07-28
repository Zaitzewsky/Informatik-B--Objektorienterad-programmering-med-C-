using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Repository;

namespace GUI
{
    public partial class LäggTillPodcast : Form
    {
        private FeedReader reader;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private SamlingsBibliotek samlingsBibliotek;
        private IntervallBibliotek intervallBibliotek;
        private ValideringInData validering;
        private ValideringUrlLäggTillPodcast valideringUrl;
        private Main form;
        public LäggTillPodcast(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            reader = new FeedReader();
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            intervallBibliotek = new IntervallBibliotek();
            validering = new ValideringInData();
            valideringUrl = new ValideringUrlLäggTillPodcast();
            form = inForm;

            samlingsBibliotek = inSamlingsBibliotek;

            guiHanterare.PrintaIntervaller(cbIntervall, intervallBibliotek);
            guiHanterare.UppdateraKategoriComboBox(cbKategorier, samlingsBibliotek);
        }

        private void btnSkapaPrenumeration_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    reader.SkapaPrenumeration(txtUrl, cbKategorier, cbIntervall, samlingsBibliotek);
                    form.uppdateraKategorier();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBekräfta_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidKategorinamn())
                {
                    bibliotekHanterare.LäggTillKategoriBibliotekTillSamlingsLista(txtLäggTillKategori, samlingsBibliotek);
                    guiHanterare.UppdateraKategoriComboBox(cbKategorier, samlingsBibliotek);
                    form.uppdateraKategorier();
                    txtLäggTillKategori.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isValidKategorinamn()
        {
            if (!validering.IsPresent(txtLäggTillKategori))
            {
                return false;
            }

            return true;
        }

        private bool isValidData()
        {
            if (!validering.IsRSS(txtUrl))
            {
                return false;
            }
            if (!validering.IsSelected(cbKategorier))
            {
                return false;
            }
            if (!validering.IsSelected(cbIntervall))
            {
                return false;
            }
            if (!valideringUrl.UrlAlreadyExist(txtUrl, samlingsBibliotek))
            {
                return false;
            }

            return true;
        }
    }
}
