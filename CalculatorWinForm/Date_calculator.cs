using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Date_calculator : Form
    {
        public Date_calculator()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Difference between dates");
            comboBox1.Items.Add("Add or subtract dates");
            comboBox1.SelectedIndex = 0; // Sets default selection
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOperation = comboBox1.SelectedItem.ToString();
            if (selectedOperation == "Add or subtract dates")
            {
                Date_operation dateOperationForm = new Date_operation();
                dateOperationForm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePicker2.Value;
            DateTime dateTo = dateTimePicker1.Value;
            string selectedOperation = comboBox1.SelectedItem.ToString();

            if (dateFrom.Date == dateTo.Date)
            {
                label1.Text = "Same Dates";
                return;
            }

            switch (selectedOperation)
            {
                case "Difference between dates":
                    TimeSpan difference = dateTo - dateFrom;
                    label1.Text = $"Difference: {difference.Days} days";
                    break;

                // Uncomment and implement these cases if needed
                /*
                case "Add dates":
                    DateTime resultAdd = dateFrom.AddYears(years).AddMonths(months).AddDays(days);
                    label1.Text = $"Result after adding: {resultAdd.ToShortDateString()}";
                    break;

                case "Subtract dates":
                    DateTime resultSubtract = dateFrom.AddYears(-years).AddMonths(-months).AddDays(-days);
                    label1.Text = $"Result after subtracting: {resultSubtract.ToShortDateString()}";
                    break;
                */

                default:
                    label1.Text = "Incorrect operation.";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
