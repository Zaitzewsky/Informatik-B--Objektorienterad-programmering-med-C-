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
    public partial class ÄndraUppdateringsintevall : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private IntervallBibliotek intervallBibliotek;
        private ValideringInData valideringInData;
        private Main form;
        public ÄndraUppdateringsintevall(SamlingsBibliotek insSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = insSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            intervallBibliotek = new IntervallBibliotek();
            valideringInData = new ValideringInData();
            form = inForm;

            guiHanterare.PrintaIntervaller(cbNyIntervall, intervallBibliotek);
            guiHanterare.UppdateraKategoriComboBox(cbKategori, samlingsBibliotek);
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.ÄndraUppdateringsIntervall(cbKategori, cbPodcast, cbNyIntervall, samlingsBibliotek);
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
            if (!valideringInData.IsSelected(cbKategori))
            {
                return false;
            }
            if (!valideringInData.IsSelected(cbNyIntervall))
            {
                return false;
            }
            if (!valideringInData.IsSelected(cbPodcast))
            {
                return false;
            }

            return true;
        }
    }
}
