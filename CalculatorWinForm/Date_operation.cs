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
    public partial class Date_operation : Form
    {
        public Date_operation()
        {
            InitializeComponent();
            InitializeComboBoxes();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void InitializeComboBoxes()
        {
            comboBox1.Items.Add("Difference between dates");
            comboBox1.Items.Add("Add or subtract  dates");
            for (int i = 0; i <= 999; i++)
            {
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
            }

            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
            if (comboBox3.Items.Count > 0) comboBox3.SelectedIndex = 0;
            if (comboBox4.Items.Count > 0) comboBox4.SelectedIndex = 0;

        }


        private void Date_operation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyDateOperation(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyDateOperation(false);
        }
        private void ApplyDateOperation(bool IsAdding)
        {
            //DateTime currentDate = dateTimePicker1.Value;
            //int years = (int)comboBox2.SelectedItem;
            //int months = (int)comboBox3.SelectedItem;
            //int days = (int)comboBox4.SelectedItem;

            //DateTime resultDate;

            //if (IsAdding)
            //{
            //    resultDate = currentDate.AddYears(years).AddMonths(months).AddDays(days);
            //}
            //else
            //{
            //    resultDate=currentDate.AddYears(-years).AddMonths(-months).AddDays(-days);
            //}
            //label6.Text = resultDate.ToString("dddd, MMMM d, yyyy");


            DateTime currentDate = dateTimePicker1.Value;
            int years = (int)comboBox2.SelectedItem;
            int months = (int)comboBox3.SelectedItem;
            int days = (int)comboBox4.SelectedItem;

            DateTime resultDate = IsAdding
                ? currentDate.AddYears(years).AddMonths(months).AddDays(days)
                : currentDate.AddYears(-years).AddMonths(-months).AddDays(-days);

            label6.Text = resultDate.ToString("dddd, MMMM d, yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOperation = comboBox1.SelectedItem.ToString();
            if (selectedOperation == "Difference between dates")
            {
                Date_calculator dateCalculatorForm = new Date_calculator();
                dateCalculatorForm.Show();

            }


        }
    }
}
