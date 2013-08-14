using System;
using System.Linq;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private string _currentValue;
        private string _lastValue;
        private char _lastOperation;

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
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
                case '.':
                    _currentValue += input;
                    break;
                case 'c':
                    _currentValue = null;
                    _lastValue = null;
                    break;
                case '+':
                    _lastOperation = '+';
                    _lastValue = String.Copy(_currentValue);
                    _currentValue = null;
                    break;
                case '-':
                    _lastOperation = '-';
                    _lastValue = String.Copy(_currentValue);
                    _currentValue = null;
                    break;
                case '*':
                    _lastOperation = '*';
                    _lastValue = String.Copy(_currentValue);
                    _currentValue = null;
                    break;
                case '/':
                    _lastOperation = '/';
                    _lastValue = String.Copy(_currentValue);
                    _currentValue = null;
                    break;
                case '=':
                    switch (_lastOperation)
                    {
                        case '+':
                            _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) + (Convert.ToInt32(_lastValue)));
                            break;
                        case '-': _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) - (Convert.ToInt32(_lastValue)));

                            break;
                        case '*':
                            _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) * (Convert.ToInt32(_lastValue)));
                            break;
                        case '/':
                            if (Convert.ToInt32(_lastValue) != 0)
                            {
                                _currentValue =
                                    Convert.ToString(Convert.ToInt32(_currentValue)/(Convert.ToInt32(_lastValue)));
                            }
                            else
                            {
                                _currentValue = String.Copy("DIV0");
                            }
                            break;
                    }
                    break;
            }
        }

    public string GetOutput()
        {
            if (_currentValue == "")
            {
                return null;
            }
            else
            {
                return _currentValue;
            }
        }
    }
}
