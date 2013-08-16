using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private double _currentValue = 0;
        private double _accumulator = 0;
        private char _activeOperator = '=';
        private bool _buildingNumber;
        private string _OutOfRangeWarning = "";

        private void _Reset()   // or initializer - don't know C# approach yet
        {
            _currentValue = 0;
            _accumulator = 0;
            _activeOperator = '=';
            _OutOfRangeWarning = "";


        }
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            //
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
                    _buildingNumber = true;
                    if ((double.MaxValue - (input - '0')) / 10 >= _currentValue)
                        _currentValue = _currentValue * 10 + (input - '0');
                    else
                        _OutOfRangeWarning = "too big"; // calc just plays a 'ding' instead
                    break;
                case '=':
                case '+':
                case '-':
                case '/':
                case '*':
                    if (_buildingNumber)
                        _ApplyPrevOperator();
                    _activeOperator = input;
                    _buildingNumber = false;
                    break;
                case 'c':
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
                    if (isValidForAddition( _accumulator, _currentValue))
                        _accumulator += _currentValue;
                    break;
                case '-':
                    if (isValidForSubtraction( _accumulator, _currentValue))
                        _accumulator -= _currentValue;
                    break;
                case '*':
                    if (isValidForSubtraction( _accumulator, _currentValue))
                        _accumulator *= _currentValue;
                    break;
                case '/':
                    if (isValidForDivision(_accumulator, _currentValue))
                        _accumulator /= _currentValue;
                    break;
            }
            _currentValue = 0;
            _activeOperator = ' ';

        }

        private Boolean isValidForAddition(double operand1, double operand2)
        {
            if (operand1 > 0 && (double.MaxValue - operand1) < operand2)
            {
                _OutOfRangeWarning = "overflow"; // calc switches to scientific notation
                return false;
            }
            return true;

        }

        private Boolean isValidForSubtraction (double operand1, double operand2)
        {
            if (operand1 < 0 && (operand1 - double.MinValue) < operand2)
            {
                _OutOfRangeWarning = "underflow"; // calc switches to scientific notation
                return false;
            }
            return true;

        }

        private Boolean isValidForMultiplication(double operand1, double operand2)
        {
            if (operand1 > 0 && (double.MaxValue/operand1) < operand2)
            {
                _OutOfRangeWarning = "overflow"; // calc switches to scientific notation
                return false;
            }
            return true;
        }

        private Boolean isValidForDivision(double operand1, double operand2)
        {
            if (operand1 == 0 && operand2 == 0)
            {
                _OutOfRangeWarning = "Result is undefined";
                return false;
            }

            if (operand2 == 0)
            {
                _OutOfRangeWarning = "Cannot divide by zero";
                return false;
            }

            return true;
        }

        public string GetOutput()
        {
            string _returnstring;

            // test if _currentValue is out of range or an error before returning it.
            if (_OutOfRangeWarning.Length > 0)
            {
                _returnstring = _OutOfRangeWarning;
                _OutOfRangeWarning = ""; // just report once and then clear warning
            }
            else if (_buildingNumber)
                _returnstring = _currentValue.ToString(); // + _activeOperator;
            else
                _returnstring = _accumulator.ToString(); // + _activeOperator; 

            return _returnstring;
        }
    }
}
