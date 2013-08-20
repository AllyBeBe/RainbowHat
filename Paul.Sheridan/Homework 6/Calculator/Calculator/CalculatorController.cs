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

        public CalculatorController()
        {
            ResetCalculatorState();
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.

        public void AcceptCharacter(char input)
        {
            if (input == 'c')
            {
                ResetCalculatorState();
            }
            else if (input == '+')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                _operator = "+";
                _isWaitingForSecondOperand = true;
                _equalsWasJustPressed = false;
            }
            else if (input == '-')
            {
                // If Operator is not null (we already have an operator entered), 
                // execute the math operation represented by Operator (the saved operator).
                // Otherwise, just copy _currentValue into 
                // _previousValue, and set _currentValue to 0
                if (_operator != null)
                {
                    DoMathWithSavedOperator();
                }
                else
                {
                    _previousValue = _currentValue;
                    _currentValue = 0;                    
                }
                _operator = "-";
                _isWaitingForSecondOperand = true;
                _equalsWasJustPressed = false;
            }
            else if (input == '*')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                _operator = "*";
                _isWaitingForSecondOperand = true;
                _equalsWasJustPressed = false;
            }
            else if (input == '/')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                _operator = "/";
                _isWaitingForSecondOperand = true;
                _equalsWasJustPressed = false;
            }
            else if (input == '=')
            {
                DoMathWithSavedOperator();
                _isWaitingForSecondOperand = false;
                _previousValue = _currentValue;
                _equalsWasJustPressed = true;
            }
            else // Digit has been typed
            {
                // If we were waiting for a second operand, we're not
                // anymore -- we've started getting the second operand.
                // If we weren't waiting for a second operand, this line
                // has no effect (and is harmless).
                _isWaitingForSecondOperand = false;

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
                    _equalsWasJustPressed = false;
                }
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

        // (alternate approach, have a lookup table from the
        // operator character to a function that does the
        // appropriate math)
        private void DoMathWithSavedOperator()
        {
            // Take saved values _previousValue and _currentValue
            // and if the operator was +, add them,
            if (_operator == "+")
            { 
                _currentValue = _previousValue + _currentValue;
                _previousValue = 0;
            }
            // if the operator was -, subtract them, 
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
                        ;
                    }
                    else
                    {
                        ;
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
            if (_isWaitingForSecondOperand)
            {
                return _previousValue.ToString();
            }
            return _currentValue.ToString();
        }
    }
}
