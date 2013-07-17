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

        private void button1_Click(object sender, EventArgs e)
        {
            String message;

            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            String rawPhoneNumber = maskedTextBox1.Text;

            maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (userName == null || userName.Length == 0)
            {
                message = "Please enter your name for a proper greeting";
            }
            else if (rawPhoneNumber == null || rawPhoneNumber.Length == 0)
            {
                message = "Please enter your phone number";
            }
            else
            {
                message = "Hello " + userName + ", we've gone fishing so we'll call you later at " + maskedTextBox1.Text + "!";
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Invalid value for a phone number!");
        }
    }
}
