using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operend2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operend2 = string.Empty;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if(this.operand1 != string.Empty && this.operend2 != string.Empty)
            {
                
            }
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            operend2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operend2, out num2);
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operend2 = string.Empty;
            if (operation == '+')
            {
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if(operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/ZERO";
                }
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ",";
            this.textBox1.Text += input;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
