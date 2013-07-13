using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework_2
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

    
        private void aMessage()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nothing was entered");
            }
            else
            {
                MessageBox.Show("Hi " + textBox1.Text + " Read about yourself on the internet");
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aMessage();
           
            BrowseWeb();
        }


        private void BrowseWeb()
        {
                
                webBrowser1.Navigate("google.com " + textBox1.Text);
          
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (e.KeyChar == (char)Keys.Enter)
                {
                    aMessage();
                    
                    BrowseWeb();
                }
         }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            Form2 x = new Form2();
            x.Show();


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.MaxLength = 11;

                if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13))
                {
                    e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13);
                    MessageBox.Show("Only Numbers Allowed", "Error");

                }
                if (textBox2.TextLength == 11)
                {
                    MessageBox.Show("Max Digits is 11");
                }
           

      }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.MaxLength = 30;
            string x = textBox2.Text;

           
            if (textBox2.TextLength == 7)
            {
                textBox2.Text = x.Substring(0, 3) + " - " + x.Substring(3, 4);
            }
            else if (textBox2.TextLength == 10 && !x.Contains("-"))
            {
                textBox2.Text = x.Substring(0, 3) + " - " + x.Substring(3, 3) + " - " + x.Substring(6, 4);
            }
            else if (textBox2.TextLength == 11)
            {
                if (x.StartsWith("1"))
                {
                    textBox2.Text = x.Substring(0, 1) + " - " + x.Substring(1, 3) + " - " + x.Substring(4, 3) + " - " + x.Substring(7, 4);
                }
                else
                {
                    MessageBox.Show("Invalid Number entered");
                    textBox2.Clear();
                }
            }
           
            else if (textBox2.TextLength > 11)
            {

            }
            else if (textBox2.TextLength < 7)
            {
                MessageBox.Show("Not enough digits entered");
            }
            else
            {
            }

            
        }


      
}

      
    
}
