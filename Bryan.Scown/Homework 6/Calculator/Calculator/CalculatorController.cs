using System;
using System.Windows.Forms;

namespace Calculator
{
    public class CalculatorController
    {
        
        private string _currentValue = "0";
        private string _lastInput;
        private char _lastOperation;
        private bool _clearCurrentValue;
        
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
                
                    if (_clearCurrentValue)
                    {
                        _clearCurrentValue = false;
                        _currentValue = String.Empty;
                    }
                    if (_currentValue == "0")
                    {
                        _currentValue = String.Empty;
                        _lastInput = String.Empty;
                        _clearCurrentValue = true;
                    }
                    _currentValue += input;
                    break;
                    
                case 'c':
                    _currentValue = String.Empty;
                    _currentValue = "0";
                    _lastInput = String.Empty;
                    _clearCurrentValue = true;
                    break;
                case '+':
                    _lastOperation = '+';
                    _lastInput = String.Copy(_currentValue);
                    _clearCurrentValue = true;
                    break;
                case '-':
                    _lastOperation = '-';
                    _lastInput = String.Copy(_currentValue);
                    _clearCurrentValue = true;
                    break;
                case '*':
                    _lastOperation = '*';
                    _lastInput = String.Copy(_currentValue);
                    _clearCurrentValue = true;
                    break;
                case '/':
                    _lastOperation = '/';
                    _lastInput = String.Copy(_currentValue);
                    _clearCurrentValue = true;
                    break;
                case '=':
                    switch (_lastOperation)
                    {
                        case '+':
                            _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) + (Convert.ToInt32(_lastInput)));
                            break;
                        case '-': 
                            _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) - (Convert.ToInt32(_lastInput)));
                            break;
                        case '*':
                            _currentValue = Convert.ToString(Convert.ToInt32(_currentValue) * (Convert.ToInt32(_lastInput)));
                            break;
                        case '/':
                            _currentValue = Convert.ToInt32(_lastInput) != 0 ? Convert.ToString(Convert.ToInt32(_currentValue)/(Convert.ToInt32(_lastInput))) : String.Copy("DIV0");
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
            if (_currentValue.Length > 16)
            {
                return _currentValue.Substring(0, 16);
            }
            return _currentValue;
        }
        
    }
}
