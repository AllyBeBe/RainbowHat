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
            if (button1.Text != "That's my phone number.")
            {

                string name = textBox1.Text;
                label1.Text = "Thanks, " + name + ".\n\nNext enter a 10 digit phone number.";
                button1.Text = "That's my phone number."; //"save" button.

                textBox1.Clear();
                textBox1.Select();
            }
            else
            {

            // the flaw is you can't undo/edit/go back, etc. once the name has been accepted.

            string phonenum = textBox1.Text.Trim();
            
            // phone numbers are really complicated to validate well - country codes, valid area codes, etc.  This wasn't easy for me, sadly.  And I don't think it's good, just good enough.
            ulong x; //Int32 was too short to hold 999 999 9999.  Area code 999 is reserved for potential expansion :)
            
            bool results = ulong.TryParse(phonenum, out x); // sledge hammer attempt at verifying just numbers. Thanks Google!
            if (!results)
	        {
		        label1.Text = "Can you try that again?\nI'm too stupid to handle anything but 10 numbers.\nIt should look like: 5551112222 if that helps.";
	        }
            else if (phonenum.Length != 10)
            {
                label1.Text = "Can you try that again?\nThere aren't 10 digits.\n\nMath is hard.";
            }
            else
            {
                label1.Text = "Saved";
                button1.Hide();
                textBox1.Hide();
                pictureBox1.Show(); //laughing?  It's hard to see. It's a guy wearing a fish-hat. I took that at Fred Meyer.  So, no, I diddn't wonder about the rainbow hat.  It's rather stylish in comparison.

                System.IO.File.WriteAllText(@"C:\users\public\Contact.txt", phonenum);
                linkLabel1.Show();
             }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();  // tried .focus(), but that didn't work.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\users\public\Contact.txt");
        }
    }
}
