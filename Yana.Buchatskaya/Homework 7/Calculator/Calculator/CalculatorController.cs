using System;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private double _currentValue;
        private double _previousValue;
        private string _operator;
        private bool _isWaitingForSecondOperand;
        private bool _equalsWasJustPressed;
        private bool _isDivideZeroByZero;
        private bool _isDivideNumberByZero;

        public CalculatorController()
        {
            ResetCalculatorState();
        } 

        public void AcceptCharacter(char input)
        {
            switch (input)
            {
                case 'c':
                    ResetCalculatorState();
                    break;
                case '+':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "+";
                    _isWaitingForSecondOperand = true;
                    _equalsWasJustPressed = false;
                    break;
                case '-':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _operator = "-";
                    _isWaitingForSecondOperand = true;
                    _equalsWasJustPressed = false;
                    _previousValue = _currentValue;
                     _currentValue = 0;
                    break;
                case '*':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }                   
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "*";
                    _isWaitingForSecondOperand = true;
                    _equalsWasJustPressed = false;
                    break;
                case '/':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "/";
                    _isWaitingForSecondOperand = true;
                    _equalsWasJustPressed = false;
                    break;
                case '=':
                    DoMathWithSavedOperator();
                    _isWaitingForSecondOperand = false;
                    _previousValue = _currentValue;
                    _equalsWasJustPressed = true;
                    break;
                default:
                    _isWaitingForSecondOperand = false;
                    _equalsWasJustPressed = false;
                    if (_currentValue.ToString().Length < 15)
                    {
                        if (_equalsWasJustPressed == false)
                        {
                            _currentValue = _currentValue*10 + int.Parse(input.ToString());
                        }
                        else
                        {
                            _currentValue = int.Parse(input.ToString());
                            _previousValue = _currentValue;
                        }                        
                    }
                    break;
            }
        }

        private void ResetCalculatorState()
        {
            _currentValue = 0;
            _previousValue = 0;
            _operator = null;
            _isWaitingForSecondOperand = false;
            _equalsWasJustPressed = false;
        }

        private void DoMathWithSavedOperator()
        {
            if (_operator == "+")
            { 
                _currentValue = _previousValue + _currentValue;
            }
            if (_operator == "-")
            {
                _currentValue = _previousValue - _currentValue;
            }
            if (_operator == "*")
            {
                _currentValue = _previousValue * _currentValue;
            }
            if (_operator == "/")
            {
                if (_currentValue == 0)
                {
                    if (_previousValue == 0)
                    {
                        _isDivideZeroByZero = true;
                    }
                    else
                    {
                        _isDivideNumberByZero = true;
                    }
                }
                else
                {
                    _currentValue = _previousValue / _currentValue;
                }
            }
        }

        public string GetOutput()
        {
           
            if (_isDivideNumberByZero)
            {
                return "Cannot divide by zero";
            }
            if (_isDivideZeroByZero)
            {
                return "Result is undefined";
            }
            if (_isWaitingForSecondOperand)
            {
                return _previousValue.ToString();
            }
            return _currentValue.ToString();
        }
    }
}

