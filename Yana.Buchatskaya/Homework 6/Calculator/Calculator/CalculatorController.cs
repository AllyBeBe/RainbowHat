using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {

        // current value of display

        private string _currentValue = "0";

        // after last value is entered and operator is entered
        private string _lastValue = String.Empty;

        //to store last operation in memory for tests with multiple operators
        private char _lastOperation;

        // when number is added, previous number gets cleared
        private bool clearCurrentValue = true;


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

                    // clear current contests before entry is made
                    if (clearCurrentValue == true)
                    {
                        clearCurrentValue = false;
                        _currentValue = String.Empty;
                    }

                    // add to current string
                    _currentValue += input;
                    break;
            
                // when "c" is entered, clear current value and set to zero
                case 'c':
                    _currentValue = String.Empty;
                    _currentValue = "0";
                    _lastValue = String.Empty;
                    clearCurrentValue = true;
                    break;

               
                case '+':
                    _lastOperation = '+';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '-':
                    _lastOperation = '-';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '*':
                    _lastOperation = '*';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '/':
                    _lastOperation = '/';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
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
                            _currentValue = Convert.ToInt32(_lastValue) != 0 ? Convert.ToString(Convert.ToInt32(_currentValue)/(Convert.ToInt32(_lastValue))) : String.Copy("");
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

