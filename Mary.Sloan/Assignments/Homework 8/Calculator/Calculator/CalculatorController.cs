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
        private char? _savedOperator;
        private double? _firstValue;
        private double? _secondValue;
        private string _displayString;
        private bool _equalsUsed;

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
            if (_savedOperator == null)
            {
                switch (input)
                {
                    case '=':
                        break;
                    case 'c':
                        ClearValues();
                        GetOutput();
                        break;
                    default: //if the operator is hit without entering non-zero number, this will use the zero.
                        _savedOperator = input;
                        _firstValue = _currentValue;
                        _displayString = _currentValue.ToString();
                        _firstChar = true;
                        _currentValue = null;
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
                            if (_currentValue == 0 && _savedOperator == '/')
                            {
                                if (_firstValue == 0)
                                {
                                   _displayString = "Result is undefined"; // zero / zero
;                               }
                                else
                                {
                                    _displayString = "Cannot divide by zero"; // number / zero
                                }

                            }
                            else
                            {
                            _secondValue = _currentValue;
                            }

                            _equalsUsed = true;
                        }
                        else
                        {
                            _secondValue = _firstValue;

                        }
                        DoMath();
                        break;
                    case 'c':
                        ClearValues();
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
            if ((_currentValue == 0 && _firstChar == true) || (_currentValue.ToString().Length > 14))
            {
                //leading zero or greater than 15 digits.
                _displayString = _currentValue.ToString();

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
                     result = _firstValue / _secondValue;
                     break; 
                default:
                    MessageBox.Show("How'd you get here!?");
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
            _savedOperator = null;
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
