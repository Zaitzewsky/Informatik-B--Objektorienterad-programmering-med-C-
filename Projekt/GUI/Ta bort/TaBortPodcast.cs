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
    public partial class TaBortPodcast : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private ValideringInData validering;
        private Main form;
        public TaBortPodcast(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = inSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            validering = new ValideringInData();
            form = inForm;

            guiHanterare.UppdateraKategoriComboBox(cbKategorier, samlingsBibliotek);
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.TaBortPodcast(cbKategorier, cbPodcasts, samlingsBibliotek);
                    form.uppdateraKategorier();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiHanterare.PrintaTitlar(cbKategorier, cbPodcasts, samlingsBibliotek);
        }

        private bool isValidData()
        {
            if (!validering.IsSelected(cbKategorier))
            {
                return false;
            }
            if (!validering.IsSelected(cbPodcasts))
            {
                return false;
            }

            return true;
        }
    }
}
