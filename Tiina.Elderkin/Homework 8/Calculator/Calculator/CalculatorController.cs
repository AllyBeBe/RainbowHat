using System;
using System.Resources;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private double  _currentValue;
        private double  _accumulator;
        private char    _activeOperator;
        private bool    _isBuildingNumber;
        private bool    _isAfterEquals;
        private string  _outOfRangeWarning;

        public CalculatorController()
        {
            _Reset();
        }

        private void _Reset()   // or initializer - don't know C# approach yet
        {
            _currentValue       = 0;
            _accumulator        = 0;
            _activeOperator     = '=';
            _outOfRangeWarning  = "";
            _isAfterEquals      = false;
            _isBuildingNumber   = false;

        }
        // This method is the core method of CalculatorController. 
        public void AcceptCharacter(char input)
        {

            switch (input)
            {
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
                    if (_isAfterEquals)
                        _Reset();
                    if (! _isBuildingNumber)
                    {
                        _currentValue = 0;
                        _isBuildingNumber = true;
                    }
                    if (IsValidForAppendingDigit(input-'0'))
                        _currentValue = _currentValue * 10 + (input - '0');
                    break;
                case '=':
                    _ApplyPrevOperator();
                    _isBuildingNumber = false;
                    _isAfterEquals = true;
                    break;
                case '+':
                case '-':
                case '/':
                case '*':
                    if (_isBuildingNumber)
                        _ApplyPrevOperator();
                    _currentValue   = _accumulator;
                    _activeOperator = input;
                    _isBuildingNumber = false;
                    _isAfterEquals  = false;
                    break;
                case 'c':
                case 'C':
                    _Reset();
                    break;
                // anything else is simply ignored
            }
        }


        private void _ApplyPrevOperator()
        {
            switch (_activeOperator)
            {
                case '=':  // end of previous computation, transfer new base value to the accumulator
                    _accumulator = _currentValue;
                    break;
                case '+':
                    if (IsValidForAddition( _accumulator, _currentValue))
                        _accumulator += _currentValue;
                    break;
                case '-':
                    if (IsValidForSubtraction( _accumulator, _currentValue))
                        _accumulator -= _currentValue;
                    break;
                case '*':
                    if (IsValidForSubtraction( _accumulator, _currentValue))
                        _accumulator *= _currentValue;
                    break;
                case '/':
                    if (IsValidForDivision(_accumulator, _currentValue))
                        _accumulator /= _currentValue;
                    break;
            }
        }

        private Boolean IsValidForAppendingDigit(double newdigit)
        {
            if ((double.MaxValue - newdigit)/10 < _currentValue)
            {
                _outOfRangeWarning = "too big"; // calc just plays a 'ding' instead
                return false;
            }
            if (_currentValue.ToString().Length >= 15)
            {
                return false;  // this case is a result of the testing suite provided and may not be needed.
            }
            return true;

        }
        private Boolean IsValidForAddition(double operand1, double operand2)
        {
            if (operand1 > 0 && (double.MaxValue - operand1) < operand2)
            {
                _outOfRangeWarning = "overflow"; // calc switches to scientific notation
                return false;
            }
            return true;

        }

        private Boolean IsValidForSubtraction (double operand1, double operand2)
        {
            if (operand1 < 0 && (operand1 - double.MinValue) < operand2)
            {
                _outOfRangeWarning = "underflow";   // calc switches to scientific notation
                                                    // no test cases exist to test this situation
                return false;
            }
            return true;

        }

        private Boolean IsValidForMultiplication(double operand1, double operand2)
        {
            if (operand1 > 0 && (double.MaxValue/operand1) < operand2)
            {
                _outOfRangeWarning = "overflow"; // calc switches to scientific notation
                return false;
            }
            return true;
        }

        private Boolean IsValidForDivision(double operand1, double operand2)
        {
            // complaint of testing double precision == 0 implies that there is a test condition 
            // needed to make sure math precision tests exist when working with numbers that could very close to zero.
            // obviously need to decide how to handle (or not handle) numbers this small.
            //  http://www.bayesserver.com/Techniques/NumericalCode.aspx
            //  interesting info about System.Double.NaN and what this implies for handling these situations.
            //  
            if ((int) operand1 == 0 && (int) operand2 == 0)
            {
                _outOfRangeWarning = "Result is undefined";
                return false;
            }

            if ((int) operand2 == 0)
            {
                _outOfRangeWarning = "Cannot divide by zero";
                return false;
            }

            return true;
        }

        public string GetOutput()
        {
            string returnstring;

            // test if _currentValue is out of range or an error before returning it.
            if (_outOfRangeWarning.Length > 0)
            {
                returnstring = _outOfRangeWarning;
                _outOfRangeWarning = ""; 
                // just report once and then clear warning.
            }
            else if (_isBuildingNumber)
                returnstring = _currentValue.ToString(); 
                      // warning about culture & 3 overloads - don't understand enough to know if this should be tweaked or not
            else
                returnstring = _accumulator.ToString(); 

            return returnstring;
        }
    }
}
