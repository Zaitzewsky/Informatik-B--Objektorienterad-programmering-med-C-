using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enhetstester
{
    [TestClass]
    public class ValidatorTests : AbstractClass
    {
        [TestMethod]
        public override void TestIsPresent()
        {
            var validator = new ValideringInData();

            TextBox txt = new TextBox();

            txt.Text = "";

            bool result = validator.IsPresent(txt);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public override void TestIsSelected()
        {
            var validator = new ValideringInData();

            ComboBox cb = new ComboBox();

            cb.SelectedIndex = -1;

            bool result = validator.IsSelected(cb);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public override void TestIsRSS()
        {
            var validator = new ValideringInData();

            TextBox txt = new TextBox();

            txt.Text = "http://tyngreradio.libsyn.com/rs";

            bool result = validator.IsRSS(txt);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public override void TestIsDecimal()
        {
            var validator = new ValideringInData();

            TextBox txt = new TextBox();

            txt.Text = "Decimal";

            bool result = validator.IsDecimal(txt);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public override void TestIsItInt()
        {
            var validator = new ValideringInData();

            TextBox txt = new TextBox();

            txt.Text = "1,1";

            bool result = validator.IsItInt(txt);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public override void TestIsValid()
        {
            var validator = new ValideringInData();

            TextBox txt = new TextBox();

            txt.Text = "5,0";

            decimal min = 10;

            decimal max = 50;

            bool result = validator.IsValid(txt, min, max);

            Assert.AreEqual(false, result);
        }
    }
}

internal class ValideringInData
{

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

    public bool IsRSS(TextBox textBox)
    {
        if (textBox.Text != "" && textBox.Text.Contains("/rss"))
        {
            return true;
        }
        MessageBox.Show("Fältet får inte vara tomt och måste innhehålla /Rss");
        textBox.Focus();

        return false;
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

    public bool IsDecimal(TextBox textBox)
    {
        decimal number = 0m;
        if (Decimal.TryParse(textBox.Text, out number))
        {
            return true;
        }
        MessageBox.Show("Går ej att konvertera");
        textBox.Focus();
        return false;
    }

    public bool IsValid(TextBox textBox, decimal min, decimal max)
    {
        decimal number = Convert.ToDecimal(textBox.Text);
        if (number < min || number > max)
        {
            MessageBox.Show("Tal måste vara större än: " + min + "samt mindre än: " + max);
            textBox.Focus();
            return false;
        }
        return true;
    }

    public bool IsItInt(TextBox textBox)
    {
        int number = 0;
        if (Int32.TryParse(textBox.Text, out number))
        {
            return true;
        }
        MessageBox.Show("Går inte att konvertera till Int");
        textBox.Focus();
        return false;
    }
}
