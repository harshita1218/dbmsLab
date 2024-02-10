using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num1;
        double op1, op2;
        double result;
        string op;
        private void button1_Click(object sender, EventArgs e)
        {
            
            num1 = num1 + "1";
            textBox3.Text = num1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            num1 = num1 + "2";
            textBox3.Text = num1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            num1 = num1 + "3";
            textBox3.Text = num1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            num1 = num1 + "4";
            textBox3.Text = num1;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            num1 = num1 + "5";
            textBox3.Text = num1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = num1 + "6";
            textBox3.Text = num1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = num1 + "7";
            textBox3.Text = num1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = num1 + "8";
            textBox3.Text = num1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = num1 + "9";
            textBox3.Text = num1;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            op = "-";
            op1 = Convert.ToDouble(num1);
            num1 = null;
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox3.Text = null; 
            op = "+";
            op1 = Convert.ToDouble(num1);
            num1 = null;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            op = "*";
            op1 = Convert.ToDouble(num1);
            num1 = null;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            op = "/";
            op1 = Convert.ToDouble(num1);
            num1 = null;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            op2 = Convert.ToDouble(num1);
            if (op == "+")
            {
                if (result != 0)
                    result = result + op2;
                else
                    result = op1 + op2;
            }
            else if (op == "-")
            {
                if (result != 0)
                    result = result - op2;
                else
                    result = op1 - op2;
            }
            else if (op == "*")
            {
                if (result != 0)
                    result = result * op2;
                else
                    result = op1 * op2;
            }
            else if (op == "/")
            {
                if (result != 0)
                    result = result / op2;
                else
                    result = op1 / op2;
            }
            textBox3.Text = Convert.ToString(result);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1 = null;
            textBox3.Text = null;
            result = 0.0;
            op1 = 0;
            op2 = 0;
        }

        

        

        

        

        
    }
}
