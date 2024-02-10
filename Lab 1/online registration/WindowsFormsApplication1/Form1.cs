using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("CCE");
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("CSE: AI ML");
            comboBox1.Items.Add("CSE: core");
        }
        string fname,lname;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fname = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lname = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
