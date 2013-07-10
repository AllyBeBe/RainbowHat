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
    public partial class AlexHomework1Form : Form
    {
        public AlexHomework1Form()
        {
            InitializeComponent();
        }

        private void goToExtraCreditButton_Click(object sender, EventArgs e)
        {
            AlexHomework1ExtraCredit newAlexHomework1ExtraCredit = new AlexHomework1ExtraCredit();
            newAlexHomework1ExtraCredit.ShowDialog();
        }
    }
}
