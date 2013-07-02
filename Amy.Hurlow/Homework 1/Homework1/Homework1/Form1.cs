using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //
        // On button click, show a messagebox with my message, plus the text the user entered.
        //
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is what you typed:" +
                "\r\n" +
                textBox1.Text);
        }
    }
}
