using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace GUI
{
    public partial class ÄndraTillhörandeKategori : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private ValideringInData validering;
        private Main form;
        public ÄndraTillhörandeKategori(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = inSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            validering = new ValideringInData();
            form = inForm;

            guiHanterare.UppdateraKategoriComboBox(cbKategori, cbNyKategori, samlingsBibliotek);
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.BytKategori(cbKategori, cbPodcast, cbNyKategori, samlingsBibliotek);
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
            if (!validering.IsSelected(cbKategori))
            {
                return false;
            }
            if (!validering.IsSelected(cbNyKategori))
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
