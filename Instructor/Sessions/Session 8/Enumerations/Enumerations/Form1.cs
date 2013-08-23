using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumerations
{
    public partial class Form1 : Form
    {
        private string _automaticallyInitializedString;

        private Months _explicitlyInitializedMonth = Months.January;

        // Automatically initialized to zero, because it's an instance
        // variable -- and therefore it will be an invalid Months value.
        private Months _automaticallyInitializedMonth;

        public Form1()
        {
            InitializeComponent();

            // You can make an invalid Months value by casting any integer
            // to type Months.
//            Months invalidMonth = (Months) 15;
//            outputLabel.Text = invalidMonth.ToString();

            // You can get an invalid Months value very easily if 
            // zero is not a valid Months value -- just let a Months
            // instance variable be automatically initialized.=
//            outputLabel.Text = _automaticallyInitializedMonth.ToString();

            // You can fix this by manually initializing it to a default
            // value.  You could also fix it by starting the enum with
            // zero.
//            outputLabel.Text = _explicitlyInitializedMonth.ToString();

            //outputLabel.Text = "The automatically initialized string is [] it says";

//            outputLabel.Text = _automaticallyInitializedString + _automaticallyInitializedMonth;
//                Months.January.ToString() + Environment.NewLine +
//                Months.February.ToString() + Environment.NewLine +
//                Months.March.ToString() + Environment.NewLine +
//                Months.April.ToString() + Environment.NewLine +
//                Months.May.ToString() + Environment.NewLine +
//                Months.June.ToString() + Environment.NewLine +
//                Months.July.ToString() + Environment.NewLine +
//                Months.August.ToString() + Environment.NewLine +
//                Months.September.ToString() + Environment.NewLine +
//                Months.October.ToString() + Environment.NewLine +
//                Months.November.ToString() + Environment.NewLine +
//                Months.December.ToString();
        }

        private void DisplayNextMonth(Months someMonth)
        {
            // The implicit question here is, "Is the result of adding
            // an enum and an integer an enum, or an integer?"
            //
            // The answer is, "Months + Integer" is of type Months

            // The implicit question now is, "What happens if we get
            // an out-of-range enumeration value as the result of an 
            // addition?"

            outputLabel.Text = (someMonth + 1).ToString();
        }

        private void DoSomethingButtonClick(object sender, EventArgs e)
        {
            DisplayNextMonth(Months.December);
        }
    }
}
