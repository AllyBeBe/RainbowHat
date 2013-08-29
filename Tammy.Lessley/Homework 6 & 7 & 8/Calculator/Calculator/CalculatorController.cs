using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {

        private double _currentValue;
        private double _previousValue;
        private string _operator;
        private bool _isWaitingForSecondOperator;
        private bool _divideZeroByZero;
        private bool _equalButtonPushed;
        private bool _divideNumbersByZero;

        private void ResetCalculator()
        {
            _currentValue = 0;
            _previousValue = 0;
            _operator = null;
            _isWaitingForSecondOperator = false;
            _equalButtonPushed = false;
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
                        _divideZeroByZero = true;
                    }
                    else
                    {
                        _divideNumbersByZero = true;
                    }
                }
                else
                {
                    _currentValue = _previousValue / _currentValue;
                }
            }
        }
        public CalculatorController()
        {
            ResetCalculator();
        }

        public void AcceptCharacter(char input)
        {
            switch (input)
            {
                case 'c':
                    ResetCalculator();
                    break;
                case '+':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "+";
                    _isWaitingForSecondOperator = true;
                    _equalButtonPushed = false;
                    break;
                case '-':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "-";
                    _isWaitingForSecondOperator = true;
                    _equalButtonPushed = false;
                    break;
                case '*':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "*";
                    _isWaitingForSecondOperator = true;
                    _equalButtonPushed = false;
                    break;
                case '/':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "/";
                    _isWaitingForSecondOperator = true;
                    _equalButtonPushed = false;
                    break;
                case '=':
                    if (_operator != null)
                    {
                        DoMathWithSavedOperator();
                    }
                    _previousValue = _currentValue;
                    _currentValue = 0;
                    _operator = "=";
                    _isWaitingForSecondOperator = true;
                    _equalButtonPushed = false;
                    break;
                default:
                    _isWaitingForSecondOperator = false;
                    _equalButtonPushed = false;
                    if (_currentValue.ToString().Length < 16)
                    {
                        if (_equalButtonPushed == false)
                        {
                            _currentValue = _currentValue*10 + int.Parse(input.ToString());
                        }
                        else
                        {
                            _previousValue = _currentValue;
                            double d = _currentValue - int.Parse(input.ToString());
                        }
                    }
                    break;
            }
        }





        //ignore leading zeros... if the first digit is zero... if the sum of the first N digits is zero... disregard, else currentvalue...


                // Your code will eventually go here, to make all of the tests pass.

                // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!


                // Someday, this method will return the string that should be displayed in the "output window" of the 
                // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
                // return something.
            public
            string GetOutput()
          
        {
            if (_divideNumbersByZero)
            {
                return "Cannot divide by zero";
            }
            if (_divideZeroByZero)
            {
                return "Result is undefined";
            }
            if (_isWaitingForSecondOperator)
            {
                return _previousValue.ToString();
            }
            return _currentValue.ToString();
        }
    }
}