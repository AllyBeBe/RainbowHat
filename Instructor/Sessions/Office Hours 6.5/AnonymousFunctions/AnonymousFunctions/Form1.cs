using System;
using System.Windows.Forms;

namespace AnonymousFunctions
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();

            // The next two lines do EXACTLY the same thing...
            // doSomethingButton.Text += " Haha!";
            doSomethingButton.Text = doSomethingButton.Text + " Haha!";
        }
        
        // Q: If you can click both a Button and a Label, what's the difference?
        // A: Beyond just that they look different, the big difference is in the graphical *behavior* when they
        // are hovered over or clicked.  If you hover over a Button, it changes color.  If you click a Button,
        // it "indents" into the page.
        //
        // The "raised" appearance of a Button, and the color change when you hover over it, are called 
        // "affordances".  They are things that make the button "look clickable", that prompt the user to
        // think of "clicking it" as a plausible or reasonable action.
        //
        // VERY IMPORTANT: obtain a copy of "The Design of Everyday Things" by Donald Norman,
        // and read it from cover to cover.
        //
        // Also recommended:
        //      "Don't Make Me Think" -- Steve Krug
        //      "Why Software Sucks" -- David Platt
        //      http://pingv.com/blog/the-best-user-interface-is-the-one-you-dont-notice

        private void DoSomethingButtonClick(object sender, EventArgs e)
        {
            // When we say "sender is an object", we are making potentially two COMPLETELY DIFFERENT statements:
            // "sender is an instance of some class, i.e. is a 'reference type' rathe than a 'value type'"
            // "sender is of type 'object', rather than of some specific type like 'Button'"

            // "statically" -- at compile time, when nothing is actually running.
            // "dynamically" -- at run time, when code is actually being executed.

            // In a "statically typed" language, the compiler will only allow us to interact with an object
            // according to the type that the compiler *statically* (at compile time, rather than at run time)
            // knows the object to be.

            // Advantages of "dynamically typed":
            //      easy to program, because you don't have to provide type information in the code
            //
            // Advantages of "statically typed":
            //      (some kinds of) bugs get found earlier, because you always know the type of things

            // Explicit type conversions, i.e. "type casting", are actually a kind of dynamic typing.  Because
            // while *you* may be confident that the variable "sender" will always hold a value of type "Button",
            // the compiler just has to take your word for it.  Let's see what happens if you're wrong...

            // "casting" is also called "type coercion"
            Control senderAsControl = (Control)sender;

            // Use a back-slash, or "escape character", before double-quotes that you want to embed
            // in a string.  An "un-escaped double quote" will end the string, and cause syntax errors.
            //
            // "anthropomorphization" is imagining human characteristics onto something that is not human.
            string message = string.Format("Handled a click on \"{0}\" in a named method.", senderAsControl.Text);

            MessageBox.Show(message);


            // Safe vs. Unsafe Type Coercions:

            // This line is an "unsafe" type coercion, because if "sender" is a Label instead of a Button,
            // you will get an exception
            //Button senderAsButton = (Button)sender;

            // This line is a "safe" type coercion.  If "sender" is a Label instead of a Button, you will
            // get a null value in senderAsButton.
            Button senderAsButton = sender as Button;
            if (senderAsButton != null)
            {
                string secondButtonMessage = string.Format("Event handler added by {0}.", senderAsButton.Text);

                // Creating an anonymous function, or a "lambda function", or a "lambda" creates what's called
                // a "closure" -- it memorizes the context it was created in.
                secondButton.Click += (sender2, event2) => 
                    MessageBox.Show(secondButtonMessage);
            }
        }
    }
}
