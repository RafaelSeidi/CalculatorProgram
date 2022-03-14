using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox3.Text =(float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) / float.Parse(textBox2.Text)).ToString();
            if (float.Parse(textBox2.Text) == 0)
            {
                textBox3.Text = ("IMPOSSÍVEL");
                label5.Text = ("Valor 2 invalido!");
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int s = n1 ^ n2;
            textBox3.Text = s.ToString();
        }
    }
}