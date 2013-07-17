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
        private String userName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message;
            
            if (userName == null || userName.Equals(""))
            {
                message = "Please enter your name for a proper greeting";
            }
            else
            {
                message = "Hello " + userName + "!";
            }
            
            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.userName = nameTextBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = laughCheckBox.CheckState;

            switch (state)
            {
                case CheckState.Checked:
                    {
                        MessageBox.Show("Mickey is now laughing!");
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        MessageBox.Show("Mickey is no longer laughing");
                        break;
                    }
            }
        }
    }
}
