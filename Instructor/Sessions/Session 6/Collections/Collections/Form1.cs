using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        private ArrayList myThingies = new ArrayList(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void makeThingy_Click(object sender, EventArgs e)
        {
            // We could add anything to myThingies, but we 
            // shoudn't, because later we rely on all of the 
            // contents of myThingies being of type Thingy.
//            myThingies.Add(37);
            myThingies.Add(new Thingy());
            UpdateUi();
        }

        private void UpdateUi()
        {
            numberOfThingies.Text = "You have " + myThingies.Count + " thingies.";
//            numberOfThingies.Text = string.Format("You have {0} thingies.", myThingies.Count);

            // This doesn't work, because (Thingy)myThingies[0].Value is interpreted by the compiler as
            // (Thingy) (myThingies[0].Value)
            // valueOfLatestThingy.Text = string.Format("The latest thingy has the value {0}.", (Thingy)myThingies[0].Value);

            // I have to tell the compiler explicitly:
            // "myThingies[0] is a Thingy, and then I want to call
            // Value on it"
            // That is, I have to say:
            // ((Thingy)myThingies[0]).Value
            // General rule: when making an explicit type cast, 
            // wrap an extra set of parentheses around the value
            // being type-cast.
            valueOfLatestThingy.Text = string.Format("The latest thingy has the value {0}.", ((Thingy)myThingies[myThingies.Count - 1]).Value);

            // For all of the thingies in MyThingies, 
            //    add a line to the listOfThingies label
            //    that displays the index of the thingy, and 
            //    its value.

            listOfThingies.Text = String.Empty;
            foreach (Thingy thingy in myThingies)
            {
                listOfThingies.Text += string.Format("Thingy has value {0}.{1}", thingy.Value, Environment.NewLine);
            }
        }

        private void frobLatest_Click(object sender, EventArgs e)
        {
            if (myThingies.Count == 0)
            {
                MessageBox.Show("You have no thingies!");
                return;
            }

            // (<type_name>) is the swear-to-god operator.
            // Dear Compiler: I swear to god that this is a Thingy.
            // Also known as an "explicit type conversion".
            object someObject = myThingies[myThingies.Count - 1];

            // I can't do this, because a generic "object" doesn't
            // know how to be Frobbed.
            // someObject.Frob();

            // I tell the compiler, "This particular generic object
            // is actually a Thingy, I swear to god."
            Thingy latestThingy = (Thingy)someObject;
            
            // Now, I can tell this thingy, "Frob yourself."
            latestThingy.Frob();
            
            UpdateUi();
        }
    }

    internal class Thingy
    {
        public int Value { get; private set; }

        public Thingy()
        {
            Value = 1;
        }
        public void Frob()
        {
            Value += Value;  // Same as "Value = Value + Value"
        }
    }
}
