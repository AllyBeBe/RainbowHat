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
        private double _previousValueBeforeEquals = 0;
        private double _result = 0;
        private string _operator = null;
        private string _previousOperator=null;
        private bool _isWaitingForNExtNumberToStart=false;
        private bool _isAfterEquals=false;
        private bool _previousInputIsOperator = false;
        private string _previousInput = null;
        private int _calcCount = 0;
       

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
                            //_previousValue = _currentValue;
                            _currentValueString = _currentValueString + Convert.ToString(input);
                            _currentValue = Convert.ToDouble(_currentValueString);
                        }
                    }
                    else if (_isWaitingForNExtNumberToStart == false && _isAfterEquals == true && _currentValueString.Length < 15)
                    {
                        _previousOperator = null;
                        _operator = null;
                        _previousValue = 0;
                        _currentValue = 0;
                        _currentValueString = null;
                        _currentValueString = _currentValueString + Convert.ToString(input);
                        _currentValue = Convert.ToDouble(_currentValueString);
                        _isAfterEquals = false;
                    }
                    else if (_isWaitingForNExtNumberToStart == true && _isAfterEquals == false && _currentValueString.Length <= 15)
                    {
                        _previousValue = Convert.ToDouble(_currentValueString);
                        _currentValue = 0;
                        _currentValueString = null;
                        _currentValueString = _currentValueString + Convert.ToString(input);
                        _currentValue = Convert.ToDouble(_currentValueString);
                        _isWaitingForNExtNumberToStart = false;
                    }
                    break;
                case '+':
                    _previousInput = Convert.ToString(input);
                    _isAfterEquals = false;
                    if (_operator == null)
                    {
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    else
                    {
                        _previousOperator = _operator;
                        DoMath();
                        _operator = Convert.ToString(input);
                       _isWaitingForNExtNumberToStart = true;
                    }
                    break;
                case '-':
                    _previousInput = Convert.ToString(input);
                    _isAfterEquals = false;
                    if (_operator == null)
                    {
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    else
                    {
                        _previousOperator = _operator;
                        DoMath();
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    break;
                case '*':
                    _previousInput = Convert.ToString(input);
                    _isAfterEquals = false;
                    if (_operator == null)
                    {
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    else
                    {
                        _previousOperator = _operator;
                        DoMath();
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    break;
                case '/':
                    _previousInput = Convert.ToString(input);
                    _isAfterEquals = false;
                    if (_operator == null)
                    {
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    else
                    {
                        _previousOperator = _operator;
                        DoMath();
                        _operator = Convert.ToString(input);
                        _isWaitingForNExtNumberToStart = true;
                    }
                    break;
                case '=':
                    _isAfterEquals = true;
                    _isWaitingForNExtNumberToStart = false;
                    if (_previousInput == "+" || _previousInput == "-" || _previousInput == "*" || _previousInput == "/" || _previousInput == "=")
                    {
                        _previousValueBeforeEquals = _currentValue;
                        DoUnaryMath();
                        _calcCount = _calcCount + 1;
                    }
                    else
                    {
                        DoMath();  
                    }  
                    break;
                case 'c':
                    Reset();
                    break;
            } 
         }

        public string GetOutput()
        {
            //return "13";
            return Convert.ToString(_currentValueString);
        }

        public void Reset()
        {
            _currentValueString="0";
            _currentValue=0;
            _previousValue=0;
            _previousValueBeforeEquals = 0;
            _result = 0;
            _operator = null;
            _previousOperator=null;
            _isWaitingForNExtNumberToStart=false;
            _isAfterEquals=false;
            _previousInputIsOperator = false;
            _previousInput = null;
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
