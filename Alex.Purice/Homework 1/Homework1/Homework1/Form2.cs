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
    public partial class AlexHomework1SuperDuperExtraCreditForm : Form
    {
        public AlexHomework1SuperDuperExtraCreditForm()
        {
            InitializeComponent();
            textSpellInput.MaxLength = 50;
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            blackArtLabel.Visible = true;
            blackArtServiceLabel.Visible = true;
            spellResultLabel.Visible = true;
            spellResultLabel.Text = textSpellInput.Text;
        }

        private void textSpellInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSpellInput_KeyUp(object sender, KeyEventArgs e)
        {
            int charactersLeftForLabel;
            int currentValueLength;
            int maxTextFieldLength = this.textSpellInput.MaxLength;

            currentValueLength = this.textSpellInput.Text.Length;

            if (currentValueLength == 0)
            {
                spellInputLabel.Text = "Enter your spell (50 characters limit per spell):";
                spellServiceLabel.Visible = false;
                blackArtLabel.Visible = false;
                blackArtServiceLabel.Visible = false;
                spellResultLabel.Visible = false;
                spellResultLabel.Text = "";
                
            }
            else
            {
                charactersLeftForLabel = maxTextFieldLength - currentValueLength;
                spellInputLabel.Text = "Enter you spell (" + charactersLeftForLabel.ToString() + " characters left):";
                spellServiceLabel.Visible = true;
            }
        }


    }
}
