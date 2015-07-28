using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class ValideringInData : Basklass
    {
        public override bool IsRSS(TextBox textBox)
        {
            if (textBox.Text != "" && textBox.Text.Contains("/rss"))
            {
                return true;
            }
            MessageBox.Show("Fältet får inte vara tomt och måste innhehålla /Rss");
            textBox.Focus();

            return false;
        }

        public bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("ej tomma fält");
                textBox.Focus();
                return false;
            }

            return true;
        }

        public bool IsSelected(ComboBox comboBox)
        {
            if (Convert.ToInt32(comboBox.SelectedIndex) == -1)
            {
                MessageBox.Show("Du måste välja ett värde i listan!");
                comboBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsSelected(ListBox listbox)
        {
            if (Convert.ToInt32(listbox.SelectedIndex) == -1)
            {
                MessageBox.Show("Du måste välja en låt i listan!");
                listbox.Focus();
                return false;
            }
            return true;
        }
    }
}
