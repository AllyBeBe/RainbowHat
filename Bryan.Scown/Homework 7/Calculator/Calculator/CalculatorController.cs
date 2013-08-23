using System;
using System.Windows.Forms;

namespace Calculator
{
    public class CalculatorController
    {
        
        private string _currentValue = "0";
        private string _lastInput;
        private char? _lastOperation;
        private bool _clearCurrentValue;
        private string _resultUndefined = "Result is undefined";
        private string _cantDivideByZero = "Cannot divide by zero";
        private bool _isWaitingForNextNumToStart;
        private bool _isWaitingForSecondOperand;
        private bool _isAfterEquals;


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
                    }
                    if (_isAfterEquals == false)
                    {
                        _isWaitingForSecondOperand = true;
                        _isWaitingForNextNumToStart = true;
                        _currentValue += input;    
                    }
                    else
                    {
                        _currentValue = Convert.ToString(input);
                        _lastInput = _currentValue;    
                    }
                    _isAfterEquals = false;
                    break;
                    
                case 'c':
                    ResetCalculatorState();
                    break;
                case '+':
                    _lastOperation = '+';
                    _lastInput = _currentValue;
                    _clearCurrentValue = true;
                    _isWaitingForNextNumToStart = true;
                    _isAfterEquals = false;
                    break;
                case '-':
                    _lastOperation = '-';
                    _lastInput = _currentValue;
                    _clearCurrentValue = true;
                    _isWaitingForNextNumToStart = true;
                    _isAfterEquals = false;
                    break;
                case '*':
                    _lastOperation = '*';
                    _lastInput = _currentValue;
                    _clearCurrentValue = true;
                    _isWaitingForNextNumToStart = true;
                    _isAfterEquals = false;
                    break;
                case '/':
                    _lastOperation = '/';
                    _lastInput = _currentValue;
                    _clearCurrentValue = true;
                    _isWaitingForNextNumToStart = true;
                    _isAfterEquals = false;
                    break;
                case '=':
                    _isAfterEquals = true;
                    _isWaitingForNextNumToStart = false;
                    switch (_lastOperation)
                    {
                        case '+':
                            _currentValue = Convert.ToString(Convert.ToDouble(_lastInput) + (Convert.ToDouble(_currentValue)));
                            break;
                        case '-':
                            _currentValue = Convert.ToString(Convert.ToDouble(_lastInput) - (Convert.ToDouble(_currentValue)));
                            break;
                        case '*':
                            _currentValue = Convert.ToString(Convert.ToDouble(_currentValue) * (Convert.ToDouble(_lastInput)));
                            break;
                        case '/':
                            if (Convert.ToDouble(_currentValue) != 0)
                            {
                                _currentValue = Convert.ToString(Convert.ToDouble(_lastInput) / (Convert.ToDouble(_currentValue)));
                            }
                            else
                            {
                                _currentValue = Convert.ToInt32(_lastInput) == 0 ? _resultUndefined : _cantDivideByZero;
                            }
                            break;
                    }
                    break;
            }
        }

        public void ResetCalculatorState()
        {
            _currentValue = "0";
            _lastInput = String.Empty;
            _clearCurrentValue = true;
            _lastOperation = null;
        }

        public string GetOutput()
        {
            if (_currentValue == "")
            {
                return null;
            }
            if (_currentValue.Length > 16 && _currentValue != _cantDivideByZero && _currentValue != _resultUndefined)
            {
                return _currentValue.Substring(0, 16);
            }
                     return _currentValue;
        }
        
    }
}
