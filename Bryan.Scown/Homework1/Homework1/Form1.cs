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
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comments = null;
            string inputText = textBox1.Text;
            string answer = "Your Response: ";

            if (textBox1.Text == string.Empty)
            {
                inputText = "You didn't enter any text";
            }
            if (textBox1.Text.Contains("hawk") || textBox1.Text.Contains("eattle"))
            {
                inputText = textBox1.Text;
                comments = "The Seattle Seahawks are my favorite team too!";
            }
            if (textBox1.Text.Contains("ittsburg") || textBox1.Text.Contains("teelers"))
            {
                inputText = textBox1.Text;
                comments = "The Steelers SUCK!!!!!!!";
            }
            MessageBox.Show(answer + inputText + "\n" + "\n" + comments);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
