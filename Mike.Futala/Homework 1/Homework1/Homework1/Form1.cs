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

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Written by\n Mike Futala", "About");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text.Trim() == String.Empty) 
            {
               MessageBox.Show("Input Box Empty", "About");
            }
            else
            {
            MessageBox.Show(textBox1.Text, "About");
            }
            }
        }
    }
;
