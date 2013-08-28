using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly CalculatorController _controller = new CalculatorController();
        public Form1()
        {
            InitializeComponent();
            _controller.AcceptCharacter('c');
            output.Text = _controller.GetOutput();
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
        private void HandleInput(char input)
        {
            _controller.AcceptCharacter(input);
            output.Text = _controller.GetOutput();
        }


        // Condensed button_click handler

        private void _buttonHolder_Click(object sender, EventArgs e)
        {
            Button sourceButton = (sender as Button);
            char buttonContent = Convert.ToChar(sourceButton.Text);

            HandleInput(buttonContent);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
