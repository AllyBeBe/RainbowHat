using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Nah, try again...");
            }
            else if (checkBox2.Checked)
            {
                System.Diagnostics.Process.Start("www.awkwardfamilyphotos.com");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("Nope...");
            }
            else
                //MessageBox.Show("no more words left");
                System.Diagnostics.Process.Start("www.youtube.com");

                

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
