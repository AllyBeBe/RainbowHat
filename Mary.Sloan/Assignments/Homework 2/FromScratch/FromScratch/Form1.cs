using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromScratch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;

            label1.Text = "Thanks, " + name + ".\n\nNext enter a 10 digit phone number.";
            button1.Text = "That's my phone number.";
            textBox1.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();  // tried .focus(), but that didn't work.
        }
    }
}
