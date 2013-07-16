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

        private void Form1_Load(object sender, EventArgs e)
        {
            pressButton.BackColor = Color.Beige;

            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
            textBox1.ForeColor = Color.Gray;

        }

        private void pressButton_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Dot Net Perls is awesome.","Awesome Message");
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text.Equals("Your Name ?") ? "" : textBox1.Text;
            label1.Text = "Hello " + text + "!";
        }


    }
}
