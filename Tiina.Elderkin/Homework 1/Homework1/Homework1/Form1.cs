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

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10. Use the Visual Studio toolbar to add a button to your application that shows your message of choice to the user." +
                Environment.NewLine + "  Hint a) Use Google and search for the term 'C# message box'" +
                Environment.NewLine + "          As of June 2013, the first google result may link to: ...",
                "Homework extra credit 10 reworded");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Response: " + textIn_Another.Text + Environment.NewLine + Environment.NewLine +
                "Even for children who perform well on academic tests, an 'A' grade is only "+
                "one measurement of success. A few things that school testing cannot measure include:"+
                Environment.NewLine + "Effort" +
                Environment.NewLine + "Critical thinking" +
                Environment.NewLine + "Creativity" +
                Environment.NewLine + "Collaboration" +
                Environment.NewLine + "Curiosity" +
                Environment.NewLine + "Respect" +
                Environment.NewLine + "Kindness" +
                Environment.NewLine + "Capacity to love" +
                Environment.NewLine + "Social and emotional intelligence" +
                Environment.NewLine + "Honesty" +
                Environment.NewLine + "Open-mindedness" +
                Environment.NewLine + "Initiative" +
                Environment.NewLine +
                Environment.NewLine + 
                "http://www.psychologytoday.com/blog/the-moment-youth/201108/the-fallacy-good-grades",
                "Psychology Today - The Fallacy of Good Grades");
        }
    }
}
