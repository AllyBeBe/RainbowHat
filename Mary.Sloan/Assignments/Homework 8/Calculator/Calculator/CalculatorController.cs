using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.

    // my problem is I think in static classes. 
    public class CalculatorController
    {


        private double? _currentValue;
        bool _firstChar;
        private char _savedOperator;  //char doesn't have a null/empty value to check from what I could find.
        private double? _firstValue;
        private double? _secondValue;
        private string _displayString;
        private bool _equalsUsed;

        public CalculatorController()
        {
            ClearValues();
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
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
            if (_savedOperator == 'e')
            {
                switch (input)
                {
                    case '=':
                        GetOutput(); // don't do anything if equals used without having a saved operator first.
                        break;
                    case 'c':
                        ClearValues();
                        GetOutput();
                        break;
                    default: //if the operator is hit without entering non-zero number, this will use the zero.
                        _savedOperator = input;
                        _firstValue = _currentValue;
                        _displayString = _currentValue.ToString();

                        GetOutput();

                        _firstChar = true; //leading zero prevention for 2nd value.
                        _currentValue = null; //empty for 2nd value.
                        break;
                }
            }
            else // there's a saved operator and a firstValue.
            {
                switch (input)
                {
                    case '=':
                        if (_currentValue.HasValue)
                        {
                            _secondValue = _currentValue;
                            DoMath();
                            _equalsUsed = true;
                        }
                        else
                        {
                            _secondValue = _firstValue;
                            DoMath();
                        }
                        break;
                    case 'c':
                        ClearValues();
                        GetOutput();
                        break;
                    default: // using a 2nd operator.  Should act like equals.

                        if (_currentValue.HasValue)
                        {
                            _secondValue = _currentValue;
                            DoMath();
                            _savedOperator = input;
                        }
                        else
                        {
                            _savedOperator = input;
                        }
                        break;
                }
            }
        }

        private void HandleDigitInput(char input)
        {
            if ((input == '0' && _firstChar == true) || (_currentValue.ToString().Length > 14))
            {
                //leading zero or greater than 15 digits.
                _displayString = _currentValue.ToString();
                GetOutput();
            }
            else
            {
                if (_equalsUsed)
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
                GetOutput();

                _firstChar = false;
            }
        }

        void DoMath()
        {
            double? result = 0;

            switch (_savedOperator)
            {
                case '+':
                    result = _firstValue + _secondValue;
                    break;
                case '-':
                    result = _firstValue - _secondValue;
                    break;
                case '*':
                    result = _firstValue*_secondValue;
                    break;
                case '/':
                    if (_secondValue == 0)
                    {
                        _displayString = "Cannot divide by zero";
                        break;
                    }
                    else
                    {
                        result = _firstValue / _secondValue;
                        break; 
                    }
 
                default:
                    MessageBox.Show("How'd you get here?");
                    break;

            }
            _displayString = result.ToString();
            _firstValue = result;
        }

        void ClearValues()
        {
            _currentValue = null;
            _displayString = "0";
            _firstChar = true;
            _firstValue = null;
            _secondValue = null;
            _savedOperator = 'e';
            _equalsUsed = false;
        }
        
        public string GetOutput()
        {
            if (_displayString == string.Empty)
            {
                _displayString = "0";
            }
            return _displayString;
        }
    }
}
