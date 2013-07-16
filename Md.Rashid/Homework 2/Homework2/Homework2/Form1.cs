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

            savedLabel.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Validate the number input
            String text2 = textBox2.Text.Trim();
            String text3 = textBox3.Text.Trim();
            String text4 = textBox4.Text.Trim();
            String text5 = textBox5.Text.Trim();


            if (text2.Length == 0 || text3.Length == 0 || text4.Length == 0 || text5.Length == 0) 
            {
                MessageBox.Show("Please check your phone number input again, you are missing some numbers","Input Validation Error !");
            }
            else if (text2.Length != 1 || text3.Length != 3 || text4.Length != 3 || text5.Length != 4)
            {
                MessageBox.Show("Please check your phone number input again, you may have entered more or less digits", "Input Validation Error !");
            }
            else
            {
                string Str = text2 + text3 + text4 + text5; ;
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    savedLabel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please check your phone number input again, invalid character(s) detected!", "Input Validation Error !");
                }
            }

        }


    }
}
