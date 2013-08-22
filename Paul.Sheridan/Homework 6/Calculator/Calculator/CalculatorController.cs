using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
                    AdditionState();
                    break;
                case '-':
                    SubtractionState();
                    break;
                case '*':
                    MultiplicationState();
                    break;
                case '/':
                    DivisionState();
                    break;
                case '=':
                    EqualsState();
                    break;
                default:
                    NumberInputState(input);
                    break;
            }
        }

        private void NumberInputState(char input)
        {
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
        }

        private void EqualsState()
        {
            DoMathWithSavedOperator();
            _isWaitingForSecondOperand = false;
            _previousValue = _currentValue;
            _equalsWasJustPressed = true;
            _isDivideNumberByZero = false;
            _isDivideNumberByZero = false;
        }

        private void DivisionState()
        {
            if (_operator != null)
            {
                DoMathWithSavedOperator();
            }
            _previousValue = _currentValue;
            _currentValue = 0;
            _operator = "/";
            _isWaitingForSecondOperand = true;
            _equalsWasJustPressed = false;
        }

        private void MultiplicationState()
        {
            if (_operator != null)
            {
                DoMathWithSavedOperator();
            }
            _previousValue = _currentValue;
            _currentValue = 0;
            _operator = "*";
            _isWaitingForSecondOperand = true;
            _equalsWasJustPressed = false;
        }

        private void SubtractionState()
        {
            if (_operator != null)
            {
                DoMathWithSavedOperator();
            }
            _operator = "-";
            _isWaitingForSecondOperand = true;
            _equalsWasJustPressed = false;
            _previousValue = _currentValue;
            _currentValue = 0;
        }

        private void AdditionState()
        {
            if (_operator != null)
            {
                DoMathWithSavedOperator();
            }
            _previousValue = _currentValue;
            _currentValue = 0;
            _operator = "+";
            _isWaitingForSecondOperand = true;
            _equalsWasJustPressed = false;
        }

        private void ResetCalculatorState()
        {
            _currentValue = 0;
            _previousValue = 0;
            _operator = null;
            _isWaitingForSecondOperand = false;
            _equalsWasJustPressed = false;
            _isDivideNumberByZero = false;
            _isDivideNumberByZero = false;
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
                        _isDivideNumberByZero = false;
                    }
                    else
                    {
                        _isDivideNumberByZero = true;
                        _isDivideZeroByZero = false;
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
            // If we are waiting for a second operand, display
            // _previousValue rather than _currentValue
            if (_isDivideNumberByZero)
            {
                return "Cannot divide by zero";
            }
            if (_isDivideZeroByZero)
            {
                return "Result is undefined";
            }
            return _isWaitingForSecondOperand ? _previousValue.ToString() : _currentValue.ToString();
        }
    }
}
