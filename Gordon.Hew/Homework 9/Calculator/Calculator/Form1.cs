using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly DirkGentlyCalculatorController _controller = new DirkGentlyCalculatorController();

        private const string YellowSuffusion =
        "<body style=\"background-color:#ffff99; background-image: url(http://www.thateden.co.uk/dirk/images/yellowbg.gif); text-align:center;\">"
        + "<div><img src=\"http://www.thateden.co.uk/dirk/images/yellow.gif\" width=\"146\" height=\"69\" alt=\"a suffusion of yellow ...\"></div></body>";

        public Form1()
        {
            InitializeComponent();
            var htmlOutput = "<body style=\"background-color:#ccffcc;\">" + _controller.GetOutput() + "</body>";
            webBrowser1.DocumentText = htmlOutput;
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

            var output = _controller.GetOutput();

            double result;

            if (Double.TryParse(output, out result) && result > 4 && _controller.GetJustCalculated())
            {
                webBrowser1.DocumentText = YellowSuffusion;
                _controller.Init();
            }
            else
            {
                webBrowser1.DocumentText = String.Format("<body style=\"background-color:#ccffcc;\">{0}</body>", output);
            }
        }

        private void DisplayIChing(int firstNumber, int secondNumber)
        {
            _controller.Init();
            webBrowser1.Navigate(string.Format("http://www.thateden.co.uk/dirk/pred.php?ching1={0}&ching2={1}", firstNumber, secondNumber));
        }


        // This still seems awfully wordy.  You might think about some ways that we could make this 
        // code shorter and cleaner as well, so that we didn't spend quite so many lines of code just
        // hooking these buttons up to the HandleInput function with the appropriate input character.

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

        private void ButtonDecimalClick(object sender, EventArgs e)
        {
            HandleInput('.');
        }

        private void ButtonRedClick(object sender, EventArgs e)
        {
            var r = new Random();
            DisplayIChing(r.Next(1, 9), r.Next(1, 9));
        }

        private void ButtonSineClick(object sender, EventArgs e)
        {
            HandleInput('s');
        }

        private void ButtonCosineClick(object sender, EventArgs e)
        {
            HandleInput('o');
        }

        private void ButtonTanClick(object sender, EventArgs e)
        {
            HandleInput('t');
        }

        private void ButtonSquareClick(object sender, EventArgs e)
        {
            HandleInput('q');
        }

        private void ButtonReciprocalClick(object sender, EventArgs e)
        {
            HandleInput('r');
        }

        private void ButtonPercentageClick(object sender, EventArgs e)
        {
            HandleInput('%');
        }

        private void ButtonNegateClick(object sender, EventArgs e)
        {
            HandleInput('#');
        }
    }
}
