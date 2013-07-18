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
            Answer.Text = "Your guess: " + Guess.Text + '\r' + '\r' + "The answer: A Cock-A-Poodle-Do!";
            MessageBox.Show("You clicked on the 'OK button', good for you!");      
        }

        private void question_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for rating my joke.");
        }

     

      
    }
}
