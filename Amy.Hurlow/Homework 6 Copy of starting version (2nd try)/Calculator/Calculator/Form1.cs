using System;
using System.Windows.Forms;

namespace Calculator
        // AEH: Form1 is a class.  CalculatorController is a class.  How do they talk?  What kinds of things should
        // they contain -- just methods, or variables too?  How do classes relate to objects?
{
    public partial class Form1 : Form
    {
        // AEH: Create new object instance named _controller as part of object class CalculatorController?
        // or is this creating a new type of object, in which case where are the instances created?
        // AEH: CalculatorController is a class.  So why does it need arguments in the second mention, but not the first?
        private readonly CalculatorController _controller = new CalculatorController();

        // AEH: Is Form1 a method?  Variable?  Object?  How does it realte to CalculatorController?  Why are they separate files?
        public Form1()
        {
            InitializeComponent(); // What does this do?
            output.Text = _controller.GetOutput();  // What the heck?
        }

        // I noticed that the same basic code was showing up in all of the methods: 
        //      output.Text = _controller.AcceptCharacter('?')
        // Whenever I see duplicated code, I want to get rid of it -- it's more places where
        // errors can occur, more things I have to read over to find the "meat" of the code,
        // more stuff to modify and maintain if I want to make a change later.
        //
        // So, I wrote this "helper method" to encapsulate the redundant "boiler-plate" parts of
        // that code.  Now, each button-click handler just says 
        //      handleInput('?')"
        // and it's really easy to visually verify that each method does the intended thing.

        // AEH: What does this actually do?
        private void HandleInput(char input) // Method
        {
            _controller.AcceptCharacter(input);
            output.Text = _controller.GetOutput();
        }


        // This still seems awfully wordy.  You might think about some ways that we could make this 
        // code shorter and cleaner as well, so that we didn't spend quite so many lines of code just
        // hooking these buttons up to the HandleInput function with the appropriate input character.

        // AEH: Why is there a separate event for each button, again?  
        private void Button1Click(object sender, EventArgs e) // Events
        {
            HandleInput('1');
        }

        private void Button2Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void Button3Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void Button4Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void Button5Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void Button6Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void Button7Click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void Button8Click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void Button9Click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void Button0Click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void ButtonPlusClick(object sender, EventArgs e)
        {
            HandleInput('+');
        }

        private void ButtonMinusClick(object sender, EventArgs e)
        {
            HandleInput('-');
        }

        private void ButtonTimesClick(object sender, EventArgs e)
        {
            HandleInput('*');
        }

        private void ButtonDivideClick(object sender, EventArgs e)
        {
            HandleInput('/');
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            HandleInput('c');
        }

        private void ButtonEqualsClick(object sender, EventArgs e)
        {
            HandleInput('=');
        }
    }
}
