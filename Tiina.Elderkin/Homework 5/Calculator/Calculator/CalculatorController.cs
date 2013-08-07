using System.Collections;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private int _currentValue = 0;
        private int _accumulator = 0; 
        private char _activeOperator = '+';
        private bool _buildingNumber;
        private string _OutOfRangeWarning = "";

        private void _Reset()   // or initializer - don't know C# approach yet
        {
            _currentValue = 0;
            _accumulator = 0;
            _activeOperator = '+';
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
                    if ((int.MaxValue - (input - '0'))/10 > _currentValue)
                    {
                        _currentValue = _currentValue*10 + (input - '0');
                    }
                    else
                    {
                        _OutOfRangeWarning = "too big"; // calc just plays a 'ding' instead
                    }
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
                    _activeOperator = '+' ;
                    _accumulator = 0;
                    _currentValue = 0;
                    _OutOfRangeWarning = "";
                    break;
                // anything else is simply ignored
            }
        }


        private void _ApplyPrevOperator()
        {
            switch (_activeOperator)
            {
                //case '=':  // end of computation, just resetting modes
                  //   _accumulator = _currentValue;
                   //  break;
                case '+':
                     if (_accumulator > 0  && (int.MaxValue - _accumulator) < _currentValue)
                         _OutOfRangeWarning = "overflow"; // calc switches to scientific notation
                     else
                         _accumulator += _currentValue;
                     break;
                case '-':
                    if (_accumulator < 0 && (_accumulator - int.MinValue ) < _currentValue)
                    {
                        _OutOfRangeWarning = "underflow"; // calc switches to scientific notation
                    }
                    else
                    {
                        _accumulator -= _currentValue;
                    }
                    break;
                case '*':
                    if (_accumulator > 0 && (int.MaxValue/_accumulator) < _currentValue)
                    {
                        _OutOfRangeWarning = "overflow"; // calc switches to scientific notation
                    }
                    else
                    {
                        _accumulator *= _currentValue;
                    }
                    break;
                case '/':
                    if (_currentValue == 0)
                        _OutOfRangeWarning = "Divide by Zero";
                    else
                        _accumulator /= _currentValue;  // since this is integer calculator, it is currently DIV instead of true divide.
                    break;
             }
             _currentValue = 0;
             _activeOperator = ' ';

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
