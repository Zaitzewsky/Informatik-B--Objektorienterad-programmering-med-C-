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
    public partial class TaBortKategori : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private GUIHanterare guiHanterare;
        private ValideringInData validering;
        private Main form;
        public TaBortKategori(SamlingsBibliotek insSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = insSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            guiHanterare = new GUIHanterare();
            validering = new ValideringInData();
            form = inForm;

            guiHanterare.UppdateraKategoriComboBox(cbKategorier, samlingsBibliotek);
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.TaBortKategori(cbKategorier, samlingsBibliotek);
                    form.uppdateraKategorier();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool isValidData()
        {
            if (!validering.IsSelected(cbKategorier))
            {
                return false;
            }

            return true;
        }
    }
}
