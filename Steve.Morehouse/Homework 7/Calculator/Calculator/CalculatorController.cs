using System;
using System.Linq;

namespace Calculator
{
    public class CalculatorController
    {
        /*
         * the maximum number of characters to be displayed
         */
        private const int MAXDISPLAYCHARACTERS = 15;
        private int currentDisplayCharacters = 0;

        /*
         * the current value of the displayed register
         */
        private string _currentValue = "0";

        /*
         * this is the second register, the value which was previously entered but we need to perform the
         * selected operation upon
         */
        private string _lastValue = String.Empty;

        /*
         * we need a memory in the infix notation of what the operation is
         */
        private char _lastOperation;

        /*
         * when an operation is made, the current value still needs to be displayed.
         * however a flag is set so upon entry of a new number, the new current Value is cleared
         * 
         * this flag is initially set since the initial value is ZERO but when a user enters a number
         * it clears to what the user enters, so there are no leading zeros.
         */
        private bool clearCurrentValue = true;

        private bool _isNegative = false;

        /*
         * This currently performes arithmetic in a infix notation format
         * 
         * This performs limited capability in the following areas:
         * - signed
         * - decimal
         * 
         * This does NOT perform (yet)
         *  - multiple operations
         *  - large numbers
         *  - rounding
         * 
         */
        public void AcceptCharacter(char input)
        {
            switch (input)
            {
                case '.': 
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
                    if (++currentDisplayCharacters <= MAXDISPLAYCHARACTERS)
                    {
                        numberEntered(input);
                    }
                    break;
                case 'c':
                    clear();
                    break;
                case '+':
                    currentDisplayCharacters = 0;
                    _lastOperation = '+';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '-':
                    currentDisplayCharacters = 0;
                    dashEntered(input);
                    break;
                case '*':
                    currentDisplayCharacters = 0;
                    _lastOperation = '*';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '/':
                    currentDisplayCharacters = 0;
                    _lastOperation = '/';
                    _lastValue = String.Copy(_currentValue);
                    clearCurrentValue = true;
                    break;
                case '=':
                    currentDisplayCharacters = 0;
                    equalsEntered();
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

    /*
     * CLEAR
     * 
     * clear the current value
     * display zero
     * set flag to clear to what user enters
     */
    public void clear()
    {
        _currentValue = String.Empty;
        _currentValue = "0";
        _lastValue = String.Empty;
        clearCurrentValue = true;
        _isNegative = false;
        currentDisplayCharacters = 0;
    }

    /*
     * if there was an operation made where the current contents needs to be cleared, do so now
     * before entry is made
     */
    public void numberEntered(char input)
    {
        if (clearCurrentValue == true)
        {
            /*
             * now check for leading zeros.  if so, do not reset flag
             */
            if (input != '0')
            {
                _currentValue = String.Empty;
                clearCurrentValue = false;
                _currentValue += input;
            }
            else
            {
                // even though this is still zero, still have to note this 
                _currentValue = "0";
                // don't reset flag in case there are subsequent zero entries
            }
        }
        else
        {
            if (_isNegative == true)
            {
                _isNegative = false;
                _currentValue += "-";
            }
            // keep on adding to the current string
            _currentValue += input;
        }
    }

    /*
     * if an equal is entered, we have to collect everything and determine the operation
     * to perform.  If there was no previous operation entered, clear the last command
     */
    public void equalsEntered()
    {
        switch (_lastOperation)
        {
            case '+':
                _currentValue =
                    Convert.ToString(Convert.ToDouble(_currentValue) + (Convert.ToDouble(_lastValue)));
                break;
            case '-':
                _currentValue =
                    Convert.ToString(Convert.ToDouble(_lastValue) - (Convert.ToDouble(_currentValue)));
                break;
            case '*':
                _currentValue =
                    Convert.ToString(Convert.ToDouble(_currentValue) * (Convert.ToDouble(_lastValue)));
                break;
            case '/':
                if (Convert.ToInt64(_currentValue) != 0)
                {
                    _currentValue =
                        Convert.ToString(Convert.ToDouble(_lastValue) / (Convert.ToDouble(_currentValue)));
                }
                else // got a problem (double zero or zero divisor)
                {
                    // both values are zero
                    if (Convert.ToInt64(_lastValue) == 0)
                    {
                        _currentValue = String.Copy("Result is undefined");
                    }
                    else // divisor only is zero
                    {
                        _currentValue = String.Copy("Cannot divide by zero");
                    }
                }
                break;
            case '=':
                break;
            default: // there is no previous operation specified
                clearCurrentValue = true;
                break;
        }
    }

    /*
     * minus sign (overload)
     * determine if this is minus or negative
     */
    public void dashEntered(char input)
    {
        if (clearCurrentValue == true)
        {
            _currentValue = String.Empty;
            clearCurrentValue = false;
            _currentValue += input;
            /*_lastOperation = '-';
            _lastValue = "0";
            clearCurrentValue = true;
            _isNegative = true;*/
        }
        else // this is a minus
        {
            _lastOperation = '-';
            _lastValue = String.Copy(_currentValue);
            clearCurrentValue = true;
        }
    }

    }
}
