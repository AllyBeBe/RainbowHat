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
    public partial class frmHomework1 : Form
    {
        public frmHomework1()
        {
            InitializeComponent();           
        }

        private void okClick(object sender, EventArgs e)
        {
            MessageBox.Show ("Hello, " + txtUserName.Text + ".  It is nice to meet you." + "\n\nThe current system date & time is:  "+ DateTime.Now);
            
        }
    }
}
