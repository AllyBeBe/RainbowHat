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
        private List<Thingy> myThingies = new List<Thingy>(); 

        public Form1()
        {
            InitializeComponent();
            makeThingy.Click += 
                (sender, args) => MessageBox.Show("Making a thingy!");
        }

        private void makeThingy_Click(object sender, EventArgs e)
        {
            // Using generics, we are not allowed to even try to
            // add 37 to the list, because 37 is not a Thingy.
            //myThingies.Add(37);
            myThingies.Add(new Thingy());
            UpdateUi();
        }

        private void UpdateUi()
        {
            numberOfThingies.Text = "You have " + myThingies.Count + " thingies.";
            valueOfLatestThingy.Text = string.Format("The latest thingy has the value {0}.", myThingies[myThingies.Count - 1].Value);

            Thingy biggestThingy = GetLargestThingy();
            largestThingy.Text = string.Format(
                "The largest thingy is #{0}, with value {1}.", 
                myThingies.IndexOf(biggestThingy) + 1, 
                biggestThingy.Value);

            listOfThingies.Text = String.Empty;
            int thingyIndex = 1;
            foreach (Thingy thingy in myThingies)
            {
                listOfThingies.Text += string.Format(
                    "Thingy #{2} has value {0}.{1}", 
                    thingy.Value, 
                    Environment.NewLine, 
                    thingyIndex++);
            }

            listOfThingies.Text = String.Empty;
            for (int i = 0; i < myThingies.Count; i++)
            {
                Thingy thingy = myThingies[i];
                listOfThingies.Text += string.Format(
                    "Thingy #{2} has value {0}.{1}",
                    thingy.Value,
                    Environment.NewLine,
                    i + 1);
            }
        }

        private Thingy GetLargestThingy()
        {
            int valueOfLargestThingy = myThingies[0].Value;
            int indexOfLargestThingy = 0;
            foreach (Thingy thingy in myThingies)
            {
                if (thingy.Value > valueOfLargestThingy)
                {
                    valueOfLargestThingy = thingy.Value;
                    indexOfLargestThingy = myThingies.IndexOf(thingy);
                }
            }
            return myThingies[indexOfLargestThingy];
        }

        private Thingy GetLargestThingy2()
        {
            int biggestValue = GetBiggestValue();
            foreach (Thingy thingy in myThingies)
            {
                if (thingy.Value == biggestValue)
                {
                    return thingy;
                }
            }
            return null;
        }

        private int GetBiggestValue()
        {
            int biggestValue = myThingies[0].Value;
            foreach (Thingy thingy in myThingies)
            {
                if (thingy.Value > biggestValue)
                {
                    biggestValue = thingy.Value;
                }
            }
            return biggestValue;
        }

        private Thingy GetLargestThingy2WithLinq()
        {
            int biggestValue = GetBiggestValueWithLinq();
            return myThingies.First(thingy => thingy.Value == biggestValue);
        }

        private int GetBiggestValueWithLinq()
        {
            return myThingies.Select(thingy => thingy.Value).Max();
//            return myThingies.Select(GetValueFromThingy).Max();
        }

//        private int GetValueFromThingy(Thingy thingy)
//        {
//            return thingy.Value;
//        }

        private Thingy GetLargestThingy3()
        {
            Thingy largestThingy = myThingies[0];
            foreach (Thingy thingy in myThingies)
            {
                if (thingy.Value > largestThingy.Value)
                {
                    largestThingy = thingy;
                }
            }
            return largestThingy;
        }


        private void frobLatest_Click(object sender, EventArgs e)
        {
            if (myThingies.Count == 0)
            {
                MessageBox.Show("You have no thingies!");
                return;
            }

            myThingies[myThingies.Count - 1].Frob();    

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
