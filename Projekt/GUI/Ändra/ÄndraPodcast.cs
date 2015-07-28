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
    public partial class ÄndraPodcast : Form
    {
        private SamlingsBibliotek samlingsBibliotek;
        private Main form;
        public ÄndraPodcast(SamlingsBibliotek inSamlingsBibliotek, Main inForm)
        {
            InitializeComponent();
            samlingsBibliotek = inSamlingsBibliotek;
            form = inForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÄndraURL url = new ÄndraURL(samlingsBibliotek, form);
            url.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÄndraTillhörandeKategori kategori = new ÄndraTillhörandeKategori(samlingsBibliotek, form);
            kategori.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÄndraUppdateringsintevall intervall = new ÄndraUppdateringsintevall(samlingsBibliotek, form);
            intervall.Show();
        }
    }
}
