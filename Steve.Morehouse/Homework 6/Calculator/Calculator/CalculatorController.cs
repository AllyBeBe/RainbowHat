using System;
using System.Linq;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        /*
         * the current value of the displayed register
         */
        private string _currentValue = String.Empty;

        /*
         * this is the second register, the value which was previously entered but we need to perform the
         * selected operation upon
         */
        private string _lastValue = String.Empty;

        /*
         * we need a memory in the Polish notation of what the operation is
         */
        private char _lastOperation;

        /*
         * is an operation is made, the current value still needs to be displayed.
         * however a flag is set so upon entry of a new number, the new current Value is cleared
         */
        private bool clearCurrentValue = false;

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
                case '.': // not used right now
                    /*
                     * if there was an operation made where the current contents needs to be cleared, do so now
                     * before entry is made
                     */
                    if (clearCurrentValue == true)
                    {
                        clearCurrentValue = false;
                        _currentValue = String.Empty;
                    }

                    // keep on adding to the current string regardless
                    _currentValue += input;
                    break;
                case 'c':
                    _currentValue = String.Empty;
                    _lastValue = String.Empty;
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
