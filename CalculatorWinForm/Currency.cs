using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorWinForm
{
    public partial class Currency : Form
    {
        private Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>
        {
            { "USD", 1.00m },    
            { "EUR", 0.85m },
            { "GBP", 0.76m },
            { "CAD", 1.36m },
            { "JPY", 114.27m },
            { "AZN", 1.70m }    
        };
        public Currency()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendNumber(button6.Text);
        }

        private void Currency_Load(object sender, EventArgs e)
        {

        }
        private void InitializeComboBox()
        {
            var currencies = new List<string>
            {
            "USD - United States Dollar",
            "EUR - Euro",
            "GBP - British Pound Sterling",
            "CAD - Canadian Dollar",
            "JPY - Japanese Yen",
            "AZN - Azerbaijan Manat"
        };
            comboBox1.Items.AddRange(currencies.ToArray());
            comboBox2.Items.AddRange(currencies.ToArray());

            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(label1.Text, out decimal amount))
            {
                string inputCurrency = GetCurrencyCode(comboBox1.SelectedItem.ToString());
                string outputCurrency = GetCurrencyCode(comboBox2.SelectedItem.ToString());

                if (exchangeRates.TryGetValue(inputCurrency, out decimal inputRate) &&
                    exchangeRates.TryGetValue(outputCurrency, out decimal outputRate))
                {
                    // Convert amount to output currency
                    decimal convertedAmount = amount * (outputRate / inputRate);
                    label2.Text = $"{amount} {inputCurrency} = {convertedAmount:F2} {outputCurrency}";
                }
                else
                {
                    label2.Text = "Invalid currency selected.";
                }
            }
            else
            {
                label2.Text = "Invalid amount.";
            }
            
        }
        private string GetCurrencyCode(string currencyText)
        {
            return currencyText.Split(' ')[0];
        }
        private void AppendNumber(string number)
        {
            if (label1.Text == "Input")
            {
                label1.Text = number;
            }
            else
            {
                label1.Text += number;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
            {
                label1.Text += ".";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendNumber(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendNumber(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendNumber(button5.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendNumber(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendNumber(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendNumber(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendNumber(button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppendNumber(button11.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AppendNumber(button1.Text);
        }
    }
}
