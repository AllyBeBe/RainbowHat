using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertiesExamples
{
    public partial class Form1 : Form
    {
        // The "backing field" (the private variable that actually holds the value)
        // for the property FirstName
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value;
            }
        }

        // This is an "autoprop".  It is exactly the same (for LastName) as the above
        // 12 lines are for FirstName, but it's only one line.
        // Autoprops let you control access to the getter and the setter independently,
        // without the hassle of 12 lines of boiler-plate.
        public string LastName { get; private set; }

        // Syntax for a property -- has curly braces instead of a semicolon,
        // and has either a "get" method or a "set" method or both.
        public string WholeName
        {
            get
            {
                return FirstName + " " + LastName;
            }    
        }

        public string AlphabetizedName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
            set
            {
                string[] nameParts = value.Split(new [] {','});
                LastName = nameParts[0].Trim();
                FirstName = nameParts[1].Trim();
            }
        }

        public Form1()
        {
            InitializeComponent();
            FirstName = "Jonathan";
            LastName = "Seagull";

            AlphabetizedName = "Goodall, Jane";

            WholeNameLabel.Text = WholeName;
            //AlphabetizedNameLabel.Text = LastName + ", " + FirstName;
            AlphabetizedNameLabel.Text = AlphabetizedName;
        }
    }
}
