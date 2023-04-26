using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double answer, num1, num2;
        String operation = "";
        public bool dec = false;

        public void numberInput(string bNumber)
        {
            if (labelScreen.Text.Length < 7)
            {
                double num2;
                if (labelScreen.Text == "0.")
                {
                    labelScreen.Text += bNumber;
                }
                else if (Double.TryParse(labelScreen.Text, out num2) == false)
                {
                    labelScreen.Text = "";
                    labelScreen.Text += bNumber;
                }
                else if (labelScreen.Text == "0")
                {
                    labelScreen.Text = bNumber;
                }
                else
                {
                    labelScreen.Text += bNumber;
                }
            }
        }
        public void operationB(string oper)
        {
            double num2;
            operation = oper;
            if (labelScreen.Text == "")
            {
                num1 = 0;
            }
            else
            {
                if (Double.TryParse(labelScreen.Text, out num2) == false)
                {
                    operation = oper;
                    labelScreen.Text = oper;
                }
                else
                {
                    num1 = Double.Parse(labelScreen.Text);
                    labelScreen.Text = oper;
                }
            }
            dec = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelScreen.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //Leave this blank!!!!!!
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numberInput("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            numberInput("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            numberInput("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            numberInput("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            numberInput("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            numberInput("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            numberInput("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberInput("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            numberInput("9");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (labelScreen.Text.Length < 7)
            {
                double num2;
                if (labelScreen.Text == "0.")
                {
                    labelScreen.Text += "0";
                }
                else if (Double.TryParse(labelScreen.Text, out num2) == false)
                {
                    labelScreen.Text = "0";
                }
                else if(labelScreen.Text == "0")
                {
                    //Do nothing
                }
                else
                {
                    labelScreen.Text += "0";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(labelScreen.Text);
            if (Double.TryParse(labelScreen.Text, out num2) == false)
            {
                num2 = 0;
            }
                switch (operation)
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;
            }
            labelScreen.Text = answer.ToString();
            dec = false;
        }



        private void buttonC_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "";
            answer = 0;
            num1 = 0;
            operation = "";
            dec = false;
        }
        private void buttonDec_Click(object sender, EventArgs e)
        {
            double num2;
            if (Double.TryParse(labelScreen.Text, out num2) == false)
            {
                labelScreen.Text = "0.";
            }
            else
            {
                if(labelScreen.Text.Contains(".") == false)
                {
                    labelScreen.Text += ".";
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            operationB("-");
        }
        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operationB("*");
        }
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operationB("+");
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operationB("/");
        }
    }
}
