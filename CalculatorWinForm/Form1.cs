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
    public partial class Form1 : Form
    {
        float num1, ans;
        int count;
        List<string>history = new List<string>(); //it will store all history of operations
        private Scientific_Calculator scientificCalculatorForm;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            scientificCalculatorForm = new Scientific_Calculator();
        }

        private void InitializeComboBox()
        {
            //comboBox1.Items.Add("Standard Calculator");
            comboBox1.Items.Add("Scientific Calculator");
            comboBox1.Items.Add("Date Calculator");
            comboBox1.Items.Add("Currency");
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                num1=float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1=float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1= float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            //string operation = "";
            //switch (count)
            //{
            //    case 1:
            //        ans=num1-float.Parse(textBox1.Text);
            //        //textBox1.Text=ans.ToString();
            //        operation = $"{num1}-{textBox1.Text}={ans}";
            //        break;
            //    case 2:
            //        ans = num1 + float.Parse(textBox1.Text);
            //        //textBox1.Text = ans.ToString();
            //        operation = $"{num1}+{textBox1.Text}={ans}";
            //        break;
            //    case 3:
            //        ans = num1 * float.Parse(textBox1.Text);
            //        //textBox1.Text = ans.ToString();
            //        operation = $"{num1}*{textBox1.Text}={ans}";
            //        break;
            //    case 4:
            //        ans = num1 / float.Parse(textBox1.Text);
            //        //textBox1.Text = ans.ToString();
            //        operation = $"{num1}/{textBox1.Text}={ans}";
            //        break;
            //    default:
            //        break;
            //}
            //textBox1.Text=ans.ToString();
            //history.Add(operation);
            ////UpdateHistory();
            ///

            string operation = "";
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    operation = $"{num1} - {textBox1.Text} = {ans}";
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    operation = $"{num1} + {textBox1.Text} = {ans}";
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    operation = $"{num1} * {textBox1.Text} = {ans}";
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    operation = $"{num1} / {textBox1.Text} = {ans}";
                    break;
                default:
                    break;
            }
            textBox1.Text = ans.ToString();
            history.Add(operation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        //private void UpdateHistory()
        //{
        //    listBoxHistory.Items.Clear();
        //    foreach(var item in history)
        //    {
        //        listBoxHistory.Items.Add(item);
        //    }
        //}

        private void button15_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag= 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            history.Clear();
           // UpdateHistory();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.SetHistory(history);
            historyForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMode = comboBox1.SelectedItem.ToString();

            if (selectedMode == "Scientific Calculator")
            {
                if (scientificCalculatorForm.IsDisposed)
                {
                    scientificCalculatorForm = new Scientific_Calculator();
                }
                scientificCalculatorForm.Show();
                this.Hide(); 
            }
            else if (selectedMode == "Date Calculator")
            {
                Date_calculator dateCalculatorForm = new Date_calculator();
                dateCalculatorForm.Show();
                this.Hide(); 
            }
            else if (selectedMode == "Currency")
            {
                Currency currency = new Currency();
                currency.Show();
                this.Hide();
            }
            else
            {
                if (scientificCalculatorForm != null && !scientificCalculatorForm.IsDisposed)
                {
                    scientificCalculatorForm.Close();
                }
                this.Show(); // Show Form1 if no other calculator is selected
            }
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            num1=float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }


        private void SwitchToStandardMode()
        {
            
        }

        private void SwitchToScientificMode()
        {
            
        }

        private void SwitchToProgrammerMode()
        {
            
        }


    }
}
