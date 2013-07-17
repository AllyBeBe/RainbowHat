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
            MessageBox.Show("this is a test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dot Net Perls says hello.", "How is your day going?");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //
            // Detect the KeyEventArg's key enumerated constant.
            //
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(textBox1.Text);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("You pressed escape! What's wrong?");
            }
        }

    }
}
