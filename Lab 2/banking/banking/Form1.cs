using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fname, lname;
        string pass;
        string username;
        int d, m, y;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lname = this.textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fname = this.textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           //password
            pass = this.textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            username = this.textBox3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
