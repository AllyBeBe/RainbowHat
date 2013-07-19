using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int count = 10;
            while (count > 0)
            {
                count = count - 1;
                Console.WriteLine(count);
            }

            int index = 0;
            while (index < 10)
            {
                Console.WriteLine(10 - index);
                index = index + 1;
            }

//            for (int val = 10; val > 0; val--)
//            {
//                Console.WriteLine(val);
//            }


//            bool something = sadfasdf;
//
//            int size;
//            size = 7;
//
//            string val1 = something ? "Yes" : "No";
//
//            String val;
//            if (something)
//            {
//                val = "Yes";
//            }
//            else
//            {
//                val = "No";
//            }
//
//            Console.Out.WriteLine(val);
//            Console.Out.WriteLine(val1);
//
//            bool somethin = false;
//            bool orother = true;
//            if (somethin == orother)
//            {
//                MessageBox.Show("High!");
//            }
//            else
//            {
//                MessageBox.Show("low");
//            }
//
//            String someNewName = lsakdfjl;
//
//
//            switch (someNewName)
//            {
//                case "bob":
//                    Console.WriteLine("Thirteen");
//                    break;
//                case "sue":
//                    Console.WriteLine("Lucky you!");
//                    break;
//                case "tom":
//                    Console.WriteLine("Just one.");
//                    break;
//                default:
//                    Console.WriteLine("Unknown value.");
//                    break;
//            }
//
//            if (someNewName == 99 || someNewName == 13)
//            {
//                Console.WriteLine("Thirteen");
//            }
//            else if (someNewName == 7)
//            {
//                Console.WriteLine("Lucky you!");
//            }
//            else if (someNewName == 1)
//            {
//                Console.WriteLine("Just one.");
//            }
//            else
//            {
//                Console.WriteLine("Unknown value.");
//            }
        }
    }
}
