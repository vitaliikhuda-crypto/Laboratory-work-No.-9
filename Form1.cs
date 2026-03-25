using System;
using System.IO;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double amount = 0;
            string currency = "";
            double result = 0;

            if (checkBoxFile.Checked)
            {
                string[] data = File.ReadAllLines("input.txt");
                amount = Convert.ToDouble(data[0]);
                currency = data[1];
            }
            else
            {
                amount = Convert.ToDouble(textBoxAmount.Text);

                if (radioUSD.Checked) currency = "USD";
                if (radioEUR.Checked) currency = "EUR";
                if (radioPLN.Checked) currency = "PLN";
            }

            switch (currency)
            {
                case "USD":
                    result = amount * 40;
                    break;

                case "EUR":
                    result = amount * 43;
                    break;

                case "PLN":
                    result = amount * 10;
                    break;
            }

            textBoxResult.Text = result.ToString();

            File.WriteAllText("result.txt",
                "Сума: " + amount +
                "\nВалюта: " + currency +
                "\nРезультат у гривнях: " + result);
        }
    }
}
