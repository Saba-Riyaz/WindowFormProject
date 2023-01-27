using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youCalculator
{
    public partial class Form1 : Form
    {
        public double number1, number2, result;
        public string opearand;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            opearand = "+";
            number1 = Convert.ToDouble(txtBox.Text);
            txtBox.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            opearand = "-";
            number1 = Convert.ToDouble(txtBox.Text);
            txtBox.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            opearand = "*";
            number1 = Convert.ToDouble(txtBox.Text);
            txtBox.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            opearand = "/";
            number1 = Convert.ToDouble(txtBox.Text);
            txtBox.Clear();
        }

        private void btnperc_Click(object sender, EventArgs e)
        {
            opearand = "%";
            number1 = Convert.ToDouble(txtBox.Text);
            txtBox.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = " ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtBox.Text);
            if (opearand == "+")
            {
                result = number1 + number2;
                txtBox.Text = Convert.ToString(result);
                number1 = result;
            }
            if (opearand == "-")
            {
                result = number1 - number2;
                txtBox.Text = Convert.ToString(result);
                number1 = result;
            }
            if (opearand == "*")
            {
                result = number1 * number2;
                txtBox.Text = Convert.ToString(result);
                number1 = result;
            }
            if (opearand == "/")
            {
                if (number2 == 0)
                {
                    txtBox.Text = "Can,t Divide by ZERO";
                }
                else
                {
                    result= number1 / number2;
                    txtBox.Text = Convert.ToString(result);
                    number1 = result;
                }
            }
            if (opearand == "%")
            {
                if (number2 == 0)
                {
                    txtBox.Text = "Can,t Divide by ZERO";
                }
                else
                {
                    result = number1 % number2;
                    txtBox.Text = Convert.ToString(result);
                    number1 = result;
                }
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
