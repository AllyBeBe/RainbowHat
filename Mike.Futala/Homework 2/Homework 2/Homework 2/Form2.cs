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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("only Numbers allowed");
            }
          
        }

       }
    }

