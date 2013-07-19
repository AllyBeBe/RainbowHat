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
    public partial class AlexHomework1ExtraCredit : Form
    {
        public AlexHomework1ExtraCredit()
        {
            InitializeComponent();
        }

        private void showExtraCreditMessage(object sender, EventArgs e)
        {
            DialogResult proceedWithTheHomeWork = MessageBox.Show("Thank you for checking extra credit assignment.\n\n\nWould you like to proceed to super-duper extra credit part of the homework?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            switch (proceedWithTheHomeWork)
            {
                case DialogResult.Yes :
                    this.openExtaSuperDuperWindow();
                    break;
                case DialogResult.No :
                    extraCreditButton.Hide();
                    superDuperExtraCreditButton.Location = new Point(199, 102);
                    superDuperExtraCreditButton.Show();
                    //
                    break;
            }
        }

        private void superDuperExtraCreditButton_Click(object sender, EventArgs e)
        {
            this.openExtaSuperDuperWindow();
        }

        private void openExtaSuperDuperWindow()
        {
            new AlexHomework1SuperDuperExtraCreditForm().ShowDialog();
        }

    }
}
