using System;
using System.Media;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private double _displayReadout = 0;         // what is displayed in output.Text
        private double _currentTotal = 0;           // stores intermediate results from operand calculations
        private bool _isOperandEntry = false;       // indicates state of whether or not user is entering an operand
        private bool _shouldShowResults = false;    // indicates state of whether or not user user expects results from operand calculations
        private bool _errorFlag = false;            // indicates state of errors
        private char _currentOperator = '=';        /* indicates type of operation to drive switch-case decision for calculations; 
                                                       must be initialized to '=' to drive transfer of inputted to intermediate storage */
        public string DisplayResult = "";           // string holder to store double variables
        private string _errorText;                  // holds string describing errors
        private const int MaxDigitDisplay = 15; // maximum digits to display

        public void AcceptCharacter(char input)
        
        {
            switch (input)
            {
                case 'c':
                    Clear();
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    if (_shouldShowResults)
                    {
                        Clear();
                    }
                    if (! _isOperandEntry)
                    {
                        _displayReadout = 0;
                        _isOperandEntry = true;
                    }

                    if (_digitMaxReached(input - '0'))
                    {
                        _displayReadout = _displayReadout * 10 + (input - '0');
                    }
                   break;
                case '+':
                case '-':
                case '*':
                case '/':
                    if (_isOperandEntry)
                    {
                        _Calculate();
                    }
                    _displayReadout = _currentTotal;
                    _currentOperator = input;
                    _isOperandEntry = false;
                    _shouldShowResults = false;
                     break;
                case '=':
                    _Calculate();
                    _isOperandEntry = false;
                    _shouldShowResults = true;
                    break;
            }
        }

        // maximum of 15-digits per operand can be entered - modelled after WinCalc
        // sound system beep and prohibit additional digit entry
        private Boolean _digitMaxReached(double digitEntry) 
                                                            
        {
            if (_displayReadout.ToString().Length >= MaxDigitDisplay)
            {
                SystemSounds.Beep.Play();
                return false;
            }
            return true;
        }

        public void Clear() // reinitialize variables and flags.
        {
            _displayReadout = 0;
            _currentTotal = 0;
            _currentOperator = '=';
            _shouldShowResults = false;
            _isOperandEntry = false;
            _errorFlag = false;
            _errorText = string.Empty;
            DisplayResult = "0";
        }

        private void _Calculate()
        {
            switch (_currentOperator)
            {
                case '+':
                    _currentTotal += _displayReadout;
                    break;
                case '-':
                    _currentTotal -= _displayReadout;
                    break;
                case '*':
                    _currentTotal *= _displayReadout;
                    break;
                case '/':
                    if (_currentTotal == 0.0 && _displayReadout == 0.0)
                    {
                        _errorFlag = true;
                        _errorText = "Result is undefined";
                        return;
                    }
                    if (_displayReadout == 0.0)
                    {
                        _errorFlag = true;
                        _errorText = "Cannot divide by zero";
                        return;
                    }
                   
                    _currentTotal /= _displayReadout;
                    break;
                case '=':
                    _currentTotal = _displayReadout;
                    break;
            }
        }

        public string GetOutput()
        {
            if (_errorFlag)
            {
                DisplayResult = _errorText;
            }
            else if (_isOperandEntry)
            {
                DisplayResult = _displayReadout.ToString();
            }
            else
            {
                DisplayResult = _currentTotal.ToString();
            }
            return DisplayResult;
         }
    }
}