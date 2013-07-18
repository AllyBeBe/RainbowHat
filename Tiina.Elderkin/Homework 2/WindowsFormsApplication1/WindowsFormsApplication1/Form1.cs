using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { // this module is thanks to a Google Search....
   string path;
   path = System.IO.Path.GetDirectoryName( 
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
   MessageBox.Show( path );
        }
    }
}
