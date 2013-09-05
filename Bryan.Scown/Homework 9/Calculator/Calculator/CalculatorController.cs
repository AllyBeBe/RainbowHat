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
        private bool _isWaitingForSecondOperand;
        private bool _isAfterEquals;
        private string _currentValueBeforeEquals;
        private char? _lastOperatorBeforeEquals;

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
                    NumInputState(input);
                    break;
                case 'c':
                    ResetCalculatorState();
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    OperationState(input);
                    break;
                case '=':
                    EqualsState();
                    break;
            }
        }

        private void EqualsState()
        {
            if (_isAfterEquals)
            {
                _currentValue = _currentValueBeforeEquals;
                _lastOperation = _lastOperatorBeforeEquals;
                DoMath();
                _lastInput = _currentValue;
                return;
            }
            _currentValueBeforeEquals = _currentValue;
            DoMath();
            _lastOperatorBeforeEquals = _lastOperation;
            _lastOperation = null;
            _isWaitingForSecondOperand = false;
            _lastInput = _currentValue;
            _isAfterEquals = true;
        }

        private void NumInputState(char input)
        {
            _isWaitingForSecondOperand = false;
            if (_clearCurrentValue)
            {
                _clearCurrentValue = false;
                _currentValue = String.Empty;
            }
            if (_currentValue == "0")
            {
                _currentValue = String.Empty;
            }
            if ((_isAfterEquals == false) && (_currentValue.Length < 16))
            {
                _currentValue += input;
                
            }
            else if (_currentValue.Length < 16)
            {
                _currentValue = Convert.ToString(input);
                _lastInput = _currentValue;
                _lastOperation = null;
            }
            _isAfterEquals = false;
        }

        private void DoMath()
        {
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
                    if (_currentValue != "0")
                    {
                        _currentValue = Convert.ToString(Convert.ToDouble(_lastInput)/(Convert.ToDouble(_currentValue)));
                    }
                    else
                    {
                        _currentValue = Convert.ToInt32(_lastInput) == 0 ? _resultUndefined : _cantDivideByZero;
                    }
                    break;
            }
        }

        private void OperationState(char operation)
        {
            if (_isWaitingForSecondOperand)
            {
                _lastOperation = operation;
                return;
            }
            if (_lastOperation != null)
            {
                DoMath();
                _lastOperation = null;
            }
            _lastInput = _currentValue;
            _clearCurrentValue = true;
            _lastOperation = operation;
            _isWaitingForSecondOperand = true;
            _isAfterEquals = false;

        }

        public void ResetCalculatorState()
        {
            _currentValue = "0";
            _lastInput = null;
            _clearCurrentValue = true;
            _lastOperation = null;
            _isWaitingForSecondOperand = false;
            _isAfterEquals = false;
        }

        public string GetOutput()
        {
            if (_isWaitingForSecondOperand)
            {
                return _lastInput;
            }
            return _currentValue;
        }
        
    }
}
