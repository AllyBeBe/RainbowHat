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
    public partial class Homework2 : Form
    {
        public Homework2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Answer.Text = "You asked:" + Guess.Text + '\r' + '\r' + "Thank you for your question but the monkey is on his smoke break and will have to get back to you."; 
               }

        private void AskMonkey_Click(object sender, EventArgs e)
        {

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
