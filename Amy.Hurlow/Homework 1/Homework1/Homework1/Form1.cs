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
        // On button click, show a message box with my message, plus the text the user entered and an OK button.
        // Note to self (Amy): text box comes with "OK" button 
        // and automtic output of a message box with no additional text if user doesn't type in text box
        //
        //

        //
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is what you typed:" +
                "\r\n" +
                textBox1.Text);
        }
        // 
        // Amy's attempt at getting the textbox1.text to disappear on click
        // I need to find out the name of what I'm looking for
        // in order to look up what it does (or is)!
        //
        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox.
        }
    }
}
