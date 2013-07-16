using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightInGold
{
    public partial class frmWeightInGold : Form
    {
        public frmWeightInGold()
        {
            InitializeComponent();
        }

        private void cmdCalculateWeightInGold_Click(object sender, EventArgs e)
        {
            decimal userWeight = decimal.Parse(txtUserWeight.Text);
            decimal goldPrice = decimal.Parse(txtGoldPrice.Text);
            decimal WEIGHTCONVERSION = 14.5833M; //conversion factor for converting Avoirdupois pounds to Troy ounces

           // TODO: Insert code for validation and error checking for values entered into text boxes - yet to be learned.)
            decimal goldWeight = (userWeight * WEIGHTCONVERSION) * goldPrice;
            
            MessageBox.Show("Congratulations!\n\n" + "You are worth " + goldWeight.ToString("c2") + " in gold.\n\n"
                + "If the price of gold drops, eat more!", "Your Calculated Weight in Gold");
        }

        private void linkLblGoldPriceOrg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblGoldPriceOrg.LinkVisited = true;
            System.Diagnostics.Process.Start("www.goldprice.org");
        }

        private void frmWeightInGold_Load(object sender, EventArgs e)
        {
           

        }
    }
}
