using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private string _currentValueString="0";
        private double _currentValue=0;
        private double _previousValue=0;
        private double _result = 0;
        private string _operator=null;
        private string _previousOperator=null;
        private bool _isWaitingForNExtNumberToStart=false;
        private bool _isAfterEquals=false;
        private string _previousInput=null;
        private int _calcCount = 0;

        public void AcceptCharacter(char input)
        {

            switch (input)
            {
                case 'c':
                    Reset();
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    OperatorState(input.ToString());
                    break;
                case '=':
                    EqualsState(input);
                    break;
                default:
                    NumberInputState(input);
                    break;
            }
        }

        private void NumberInputState(char input)
        {
            _previousInput = Convert.ToString(input);
            if (_isWaitingForNExtNumberToStart == false && _isAfterEquals == false && _currentValueString.Length < 15)
            {
                if (_currentValueString == "0")
                {
                    _currentValueString = null;
                    _currentValueString = _currentValueString + Convert.ToString(input);
                    _currentValue = Convert.ToDouble(_currentValueString);
                }
                else
                {
                    _currentValueString = _currentValueString + Convert.ToString(input);
                    _currentValue = Convert.ToDouble(_currentValueString);
                }
            }
            else if (_isWaitingForNExtNumberToStart == false && _isAfterEquals == true && _currentValueString.Length < 15)
            {

                _currentValueString = null;
                _currentValueString = _currentValueString + Convert.ToString(input);
                _currentValue = Convert.ToDouble(_currentValueString);
            }
            else if (_isWaitingForNExtNumberToStart == true && _isAfterEquals == false && _currentValueString.Length < 15)
            {
                _currentValueString = null;
                _currentValueString = _currentValueString + Convert.ToString(input);
                _currentValue = Convert.ToDouble(_currentValueString);
            }
            _isAfterEquals = false;
            _isWaitingForNExtNumberToStart = false;
        }

        private void OperatorState(string op)
        {
            if (_operator == null)
            {
                _operator = op;
                _previousValue = _currentValue;
            }
            else
            {
                _previousValue = _currentValue;
                DoMath();
            }
           
            _isWaitingForNExtNumberToStart = true;
            _isAfterEquals = false;
            
        }

        private void EqualsState(char input)
        {
            _isAfterEquals = true;
            if (_previousInput == "+" || _previousInput == "-" || _previousInput == "*" || _previousInput == "/" || _previousInput == "=")
            {

                //DoMath();
                _operator = _previousOperator;
                DoUnaryMath();
                _calcCount = _calcCount + 1;
            }
            else
            {
                DoMath();
            }
            _isAfterEquals = false;
        }
        
        public string GetOutput()
        {
            return Convert.ToString(_currentValueString);
        }

        public void Reset()
        {
            _currentValueString="0";
            _currentValue=0;
            _previousValue=0;
            _result = 0;
            _operator=null;
            _previousOperator=null;
            _isWaitingForNExtNumberToStart=false;
            _isAfterEquals=false;
            _previousInput=null;
            _calcCount = 0;
        }

        private void DoMath()
        {
            switch (_operator)
            {
                case "+":
                    _result = _previousValue + _currentValue;
                    _currentValueString = Convert.ToString(_result);
                    break;
                case "-":
                    _result = _previousValue - _currentValue;
                    _currentValueString = Convert.ToString(_result);
                    break;
                case "*":
                    _result = _previousValue*_currentValue;
                    _currentValueString = Convert.ToString(_result);
                    break;
                case "/":
                    if (_currentValue == 0 && _previousValue != 0)
                    {
                        _currentValueString = "Cannot divide by zero";
                    }
                    else if (_previousValue == 0 && _currentValue == 0)
                    {
                        _currentValueString = "Result is undefined";
                    }
                    else
                    {
                        _result = _previousValue/_currentValue;
                        _currentValueString = Convert.ToString(_result);
                    }
                    break;
            }
        }

        private void DoUnaryMath()
        {
            switch (_operator)
            {
                case "+":
                    if (_calcCount == 0)
                    {
                        _result = _currentValue + _currentValue;
                        _currentValueString = Convert.ToString(_result);   
                    }
                    else
                    {   
                        _result = _result + _currentValue;
                        _currentValueString = Convert.ToString(_result); 
                    }
                    break;
                case "-":
                    if (_calcCount == 0)
                    {
                        _result = _currentValue - _currentValue;
                        _currentValueString = Convert.ToString(_result);
                    }
                    else
                    {
                        _result = _result - _currentValue;
                        _currentValueString = Convert.ToString(_result); 
                    }
                    break;
                case "*":
                   if (_calcCount == 0)
                    {
                        _result = _currentValue * _currentValue;
                        _currentValueString = Convert.ToString(_result);   
                    }
                    else
                    {
                        _result = _result * _currentValue;
                        _currentValueString = Convert.ToString(_result); 
                    }
                    break;
                case "/":
                    if (_currentValue == 0 && _previousValue != 0)
                    {
                        _currentValueString = "Cannot divide by zero";
                    }
                    else if (_previousValue == 0 && _currentValue == 0)
                    {
                        _currentValueString = "Result is undefined";
                    }
                    else if (_calcCount==0)
                    {
                        _result = _currentValue / _currentValue;
                        _currentValueString = Convert.ToString(_result);   
                    }
                    else
                    {
                        _result = _result / _currentValue;
                        _currentValueString = Convert.ToString(_result); 
                    }
                    break;
            }
        }

    }
}
