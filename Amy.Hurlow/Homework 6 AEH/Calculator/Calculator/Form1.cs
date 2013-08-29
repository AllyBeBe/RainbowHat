using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Calculator
// AEH: Form1 is a class.  CalculatorController is a class.  How do they talk?  How do classes relate to objects?
{
    public partial class Form1 : Form
    {
        private readonly CalculatorController _controller = new CalculatorController();
        
        // AEH: Form1 is a method? Also an object?  How does it talk to CalculatorController?  Why are they separate files?
        public Form1() // Defines Form1
        {
            InitializeComponent(); // AEH Initialize the buttons and textbox
            output.Text = _controller.GetOutput(); // AEH Do GetOutput and put what it returns in textbox.
        }

        private void HandleInput(char input)    // AEH Defines a helper method for each button click.
        {
            _controller.AcceptCharacter(input); // AEH Call AcceptCharacter (and its return).
            output.Text = _controller.GetOutput();  // AEH Call GetOutput, and put its return in the textbox.
        }

        private void Button1Click(object sender, EventArgs e)
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
