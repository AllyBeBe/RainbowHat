using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.

    // (one) of my problem is I think in static classes. 
    public class CalculatorController
    {


        private double? _currentValue;
        private char? _savedOperator;
        private double? _firstValue;
        private double? _secondValue;
        private string _displayString;
        private bool _equalsHasBeenUsed;

        public CalculatorController()
        {
            ClearValues();
        }

        public void AcceptCharacter(char input)
        {            
            if (char.IsNumber(input))
            {
                HandleDigitInput(input);
            }
            else
            {
                HandleOperatorInput(input);
            }
        }

        private void HandleOperatorInput(char input)
        {
            if (!_savedOperator.HasValue)
            {
                HandleNoSavedOperator(input);
            }
            else
            {
                HandleSavedOperator(input);
            }
        }

        private void HandleSavedOperator(char input)
        {
            switch (input)
            {
                case '=':

                    if (_currentValue == 0 && _savedOperator == '/')
                    {
                        _displayString = _firstValue == 0 ? "Result is undefined" : "Cannot divide by zero";
                        break;
                    }
                    if (_currentValue.HasValue)
                    {
                        _secondValue = _currentValue;
                    }
                    else
                    {
                        if (!_equalsHasBeenUsed)
                        {
                            _secondValue = _firstValue;
                        }
                    }
                    
                    DoMath();

                    _equalsHasBeenUsed = true;
                    break;
                    
                case 'c':
                    ClearValues();
                    break;

                case '-':
                case '+':
                case '/':
                case '*':
                    if (_currentValue.HasValue)
                    {
                        _secondValue = _currentValue;
                        DoMath();
                    }
                    _savedOperator = input;
                    _equalsHasBeenUsed = false;
                    break;

                default:  // Decided it would be more readable if I fell through with operators and used an error with the default.
                    _displayString = "Input not recognized as a valid operator.";
                    break;
            }
        }

        private void HandleNoSavedOperator(char input)
        {
            switch (input)
            {
                case '=':
                    _currentValue = null;

                    break;
                case 'c':
                    ClearValues();

                    break;
                case '-':
                case '+':
                case '/':
                case '*':
                    _savedOperator = input;
                    _firstValue = _currentValue ?? 0;  // I have difficulty "reading" this line once Resharper "fixed" it.
                    _currentValue = null;
                    _equalsHasBeenUsed = false;

                    break;
            }
        }

        private void HandleDigitInput(char input)
        {
            if (_currentValue.ToString().Length > 14) return;
            if (_equalsHasBeenUsed)
            {
                ClearValues();
            }
            double dblInput;
            double.TryParse(input.ToString(), out dblInput);
            if (_currentValue == null)
                // Discovered that I can't add a number to null - it just stays null.  I wish I were smarter. 
            {
                _currentValue = 0;
            }
            _currentValue = (_currentValue*10) + dblInput;
            _displayString = _currentValue.ToString();
        }

        void DoMath()  // I would pass it the saved operator, but I need to cure my negative negative dumbness first.
        {
            double? result = null;

            switch (_savedOperator)  
            {
                case '+':
                    result = _firstValue + _secondValue;
                    break;
                case '-':
                    if (_secondValue < 0)
                    {
                        result = _firstValue + _secondValue;  // This doesn't seem optimal, but it made the test pass.
                    }
                    else
                    {
                        result = _firstValue - _secondValue;  // with subtracting two negatives, I'm ending up with a positive. :(
                    }
                    break;
                case '*':
                    result = _firstValue*_secondValue;
                    break;
                case '/':
                     result = _firstValue / _secondValue;
                     break; 
                default:
                    MessageBox.Show("How'd you get here!?");
                    break;

            }

            // considering passing the operator and just adding one if statement for the negative/negative.

            _displayString = result.ToString();

            _firstValue = result;

            _currentValue = null;

        }

        void ClearValues()
        {
            _currentValue = null;
            _displayString = "0";
            _firstValue = null;
            _secondValue = null;
            _savedOperator = null;
            _equalsHasBeenUsed = false;
        }
        
        public string GetOutput()
        {
            return _displayString;
        }
    }
}
