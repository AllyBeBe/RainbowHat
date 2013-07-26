using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceTypes
{
    public partial class Form1 : Form
    {
        private Tiny _previousTiny;
        private Tiny _latestTiny;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _previousTiny = _latestTiny;
            _latestTiny = new Tiny();
            latestCuteness.Text = _latestTiny.GetCuteness().ToString();
            if (_previousTiny != null)
            {
                previousCuteness.Text = _previousTiny.GetCuteness().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_latestTiny == null)
            {
                MessageBox.Show("You don't have a Tiny yet!");
            }
            else
            {
                _latestTiny.BeCuter();
                latestCuteness.Text = _latestTiny.GetCuteness().ToString();
            }
        }
    }
}
