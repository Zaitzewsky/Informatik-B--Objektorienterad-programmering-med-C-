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

namespace GUI
{
    public partial class ÄndraURL : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private FeedReader reader;
        private IntervallBibliotek intervallBibliotek;
        private ValideringInData validering;
        private Main form;
        public ÄndraURL(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = inSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            reader = new FeedReader();
            intervallBibliotek = new IntervallBibliotek();
            validering = new ValideringInData();
            form = inForm;

            guiHanterare.PrintaIntervaller(cbIntervall, intervallBibliotek);
            guiHanterare.UppdateraKategoriComboBox(cbKategori, samlingsBibliotek);
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.TaBortPodcast(cbKategori, cbPodcast, samlingsBibliotek);
                    reader.SkapaPrenumeration(txtNyUrl, cbKategori, cbIntervall, samlingsBibliotek);
                    form.uppdateraKategorier();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiHanterare.PrintaTitlar(cbKategori, cbPodcast, samlingsBibliotek);
        }

        private bool isValidData()
        {
            if (!validering.IsPresent(txtNyUrl))
            {
                return false;
            }
            if (!validering.IsSelected(cbKategori))
            {
                return false;
            }
            if (!validering.IsSelected(cbIntervall))
            {
                return false;
            }
            if (!validering.IsSelected(cbPodcast))
            {
                return false;
            }

            return true;
        }
    }
}
