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
    public partial class LäggTillKategori : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private BibliotekHanterare bibliotekHanterare;
        private ValideringInData validering;
        private Main form;
        public LäggTillKategori(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();

            samlingsBibliotek = inSamlingsBibliotek;
            bibliotekHanterare = new BibliotekHanterare();
            validering = new ValideringInData();

            form = inForm;
        }

        private void btnLäggTillKategori_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    bibliotekHanterare.LäggTillKategoriBibliotekTillSamlingsLista(txtLäggTillKategori, samlingsBibliotek);
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
            if (!validering.IsPresent(txtLäggTillKategori))
            {
                return false;
            }
            return true;
        }
    }
}
