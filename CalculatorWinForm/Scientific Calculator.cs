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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CalculatorWinForm
{
    public partial class Scientific_Calculator : Form
    {
        private float num1, num2, ans;
        int count;
        private string operation;
        private List<string> history = new List<string>();
        public Scientific_Calculator()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Standard Calculator");
            comboBox1.Items.Add("Scientific Calculator");
            comboBox1.Items.Add("Date Calculator");
            comboBox1.Items.Add("Currency");
            comboBox1.SelectedIndex = 1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scientific_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 ;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            compute(count);
        }


        public void compute(int count)
        {
            string operation = "";
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    //textBox1.Text=ans.ToString();
                    operation = $"{num1}-{textBox1.Text}={ans}";
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    //textBox1.Text = ans.ToString();
                    operation = $"{num1}+{textBox1.Text}={ans}";
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    //textBox1.Text = ans.ToString();
                    operation = $"{num1}*{textBox1.Text}={ans}";
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    //textBox1.Text = ans.ToString();
                    operation = $"{num1}/{textBox1.Text}={ans}";
                    break;
                default:
                    break;
            }
            textBox1.Text = ans.ToString();
            history.Add(operation);
            //UpdateHistory();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
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
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.SetHistory(history);
            historyForm.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if(float.TryParse(textBox1.Text,out num1))
            {
                ans = (float)Math.Pow(2, num1);
                textBox1.Text = ans.ToString();
                history.Add($"2^{num1} = {ans}");
            }
            else
            {
                MessageBox.Show("Incorrect input.");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text,out int number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Factorial is not defined for negative integers.");
                }
                else
                {
                    ans = Factorial(number);
                    textBox1.Text = ans.ToString();
                    history.Add($"{number}! = {ans}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect input");
            }
        }
        private float Factorial(int number)
        {
            if(number==0 || number == 1)
            {
                return 1;
            }
            float result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            history.Add($"п={Math.PI}");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string[] parts = textBox1.Text.Split('.');

            if (parts.Length == 2)
            {
                if (float.TryParse(parts[0], out float baseValue) && float.TryParse(parts[1], out float xValue))
                {
                    if (baseValue > 0 && baseValue != 1 && xValue > 0)
                    {
                        // Compute log baseValue of xValue
                        ans = (float)(Math.Log(xValue) / Math.Log(baseValue));
                        textBox1.Text = ans.ToString();
                        history.Add($"log_{baseValue}({xValue}) = {ans}");
                    }
                    else
                    {
                        MessageBox.Show("Base and value must be positive and base must not be 1.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter numeric values.");
                }
            }
            else
            {
                MessageBox.Show("Invalid format. Use 'base.value' format.");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float xValue))
            {
                
                ans = (float)Math.Exp(xValue);
                textBox1.Text = ans.ToString();
                history.Add($"e^{xValue} = {ans}");
            }
            else
            {
                MessageBox.Show("Incorrect input.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float angle))
            {
                
                float angleInRadians = angle * (float)Math.PI / 180;

               
                ans = (float)Math.Tan(angleInRadians);

                
                textBox1.Text = ans.ToString();
                history.Add($"tan({angle}°) = {ans}"); 
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float angle))
            {
                
                float angleInRadians = angle * (float)Math.PI / 180;

                
                ans = (float)Math.Cos(angleInRadians);

                
                textBox1.Text = ans.ToString();
                history.Add($"cos({angle}°) = {ans}"); 
            }
            else
            {
                MessageBox.Show("Incorrect input. ");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float angle))
            {
                
                float angleInRadians = angle * (float)Math.PI / 180;

                
                ans = (float)Math.Sin(angleInRadians);

                
                textBox1.Text = ans.ToString();
                history.Add($"sin({angle}°) = {ans}");
            }
            else
            {
                MessageBox.Show("Incorrect input. ");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if(float.TryParse(textBox1.Text,out float number))
            {
                ans = Math.Abs(number);

                textBox1.Text = ans.ToString();

                history.Add($"abs({number}) = {ans}");
            }
            else
            {
                MessageBox.Show("Incorrect input");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float number))
            {
               
                if (number >= 0)
                {
                    
                    float sqrtValue = (float)Math.Sqrt(number);

                    
                    textBox1.Text = sqrtValue.ToString();
                    history.Add($"sqrt({number}) = {sqrtValue}");
                }
                else
                {
                  
                    MessageBox.Show("Cannot compute the square root of a negative number.");
                }
            }
            else
            {
                
                MessageBox.Show("Incorrect input.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            
            string[] parts = input.Split('.');

            if (parts.Length == 2 &&
                float.TryParse(parts[0], out float baseValue) &&
                float.TryParse(parts[1], out float exponentValue))
            {
               
                float result = (float)Math.Pow(baseValue, exponentValue);

               
                textBox1.Text = result.ToString();

               
                history.Add($"{baseValue}^{exponentValue} = {result}");
            }
            else
            {
               
                MessageBox.Show("Incorrect input.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            
            if (float.TryParse(input, out float x))
            {
                
                float result = (float)Math.Pow(10, x);

               
                textBox1.Text = result.ToString();

                
                history.Add($"10^{x} = {result}");
            }
            else
            {
               
                MessageBox.Show("Incorrect input. ");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if(float.TryParse(input,out float value))
            {
                if (value > 0)
                {
                    float result = (float)Math.Log10(value);
                    textBox1.Text = result.ToString();
                    history.Add($"log10({value}) = {result}");
                }
                else
                {
                    MessageBox.Show("Log can not be defined for negative values.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect value.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if(float.TryParse(input,out float value))
            {
                if(value > 0)
                {
                    float result = (float)Math.Log(value);
                    textBox1.Text = result.ToString();
                    history.Add($"log({value})=result");
                }
                else
                {
                    MessageBox.Show("Ln can not be defined for negative integers");
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect value.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "Standard Calculator":
                    OpenForm(new Form1()); 
                    break;
                case "Scientific Calculator":
                    OpenForm(new Scientific_Calculator()); 
                    break;
                case "Date Calculator":
                    OpenForm(new Date_calculator()); 
                    break;
                case "Currency":
                    OpenForm(new Currency()); 
                    break;
            }
        }
        private void OpenForm(Form form)
        {
            //this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
