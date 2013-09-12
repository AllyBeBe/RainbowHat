using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Input;


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
            KeyPreview = true;
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

        // condensed button_click handler
        private void _buttonHolder_Click(object sender, EventArgs e)
        {
            Button sourceButton = (sender as Button);
            char buttonContent = Convert.ToChar(sourceButton.Text);

            HandleInput(buttonContent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controller.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) // ASCII values for digits 0 - 9
            {
                HandleInput(e.KeyChar);
            }
            switch (e.KeyChar) // ASCII value for c,+,-,*,/,= operators
            {
                case (char)42: // multiplication symbol
                case (char)43: // addition symbol
                case (char)45: // subtraction symbol
                case (char)47: // division symbol
                case (char)61: // equals symbol
                case (char)67: // 'C' for clear
                case (char)99: // 'c' for clear
                    HandleInput(e.KeyChar);
                    break;
                case (char)27: // Esc key, which should clear
                    HandleInput('c');
                    break;
                case (char)13: // Enter key, which should do '='
                    HandleInput('=');
                    break;
            }
        }

        private void TreatEnterAndEscAsNormalKeys(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Escape))
            {
                e.IsInputKey = true;
            }
        }

    }
}
