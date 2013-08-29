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
        private char _operator;
        private bool _isWaitingForSecondOperator;
        private bool _equalButtonPushed;
        private string _beyondScope;

        private void _ResetCalculator()
        {
            _currentValue = 0;
            _previousValue = 0;
            _operator = '=';
            _isWaitingForSecondOperator = false;
            _equalButtonPushed = false;
            _beyondScope = "";
        }

        
        public CalculatorController()
        {
            _ResetCalculator();
        }

        public void AcceptCharacter(char input)
        {
            switch (input)
            {
               
                case 'c':
                    _ResetCalculator();
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    if (_isWaitingForSecondOperator)
                        _getPreviousOperator();
                    _currentValue = _previousValue;
                    _operator = input;
                    _isWaitingForSecondOperator = false;
                    _equalButtonPushed = false;
                    break;
                case '=':
                    _getPreviousOperator();
                    _isWaitingForSecondOperator = false;
                    _equalButtonPushed = true;
                    break;
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
                    if (_equalButtonPushed)
                        _ResetCalculator();
                    if (! _isWaitingForSecondOperator)
                    {
                        _currentValue = 0;
                        _isWaitingForSecondOperator = true;
                    }
                    
                    if (NextDigit(input - '0'))
                        _currentValue = _currentValue*10 + (input - '0');
                    break;
            }
        }

        private Boolean NextDigit(double nextNumber)
        {
            if ((double.MaxValue - nextNumber)/10 < _currentValue)
            {
                _beyondScope = "";
                return false;
            }
            if (_currentValue.ToString().Length >= 15 )
            {
                return false;
              }
            return true;
            }

        private void _getPreviousOperator()
        {
            switch (_operator)
            {
                case '/':
                    if (IsDivision(_previousValue, _currentValue))
                        _previousValue /= _currentValue;
                    break;
                case '+':
                    if (IsAddition(_previousValue, _currentValue))
                        _previousValue += _currentValue;
                    break;
                case '-':
                    if (IsSubtraction(_previousValue, _currentValue))
                        _previousValue -= _currentValue;
                    break;
                case '*':
                    if (IsMultiplication(_previousValue, _currentValue))
                        _previousValue *= _currentValue;
                    break;
                case '=':
                    _previousValue = _currentValue;
                    break;

            }
        }

        private Boolean IsAddition(double number1, double number2)
        {
            if (number1 > 0 && (double.MaxValue - number1) < number2)
            {
                _beyondScope = "";
                return false;
            }
            return true;
        }

        private Boolean IsSubtraction(double number1, double number2)
        {
            if (number1 < 0 && (number1 - double.MinValue) < number2)
            {
                _beyondScope = "";
                return false;
            }
            return true;
        }

        private Boolean IsMultiplication(double number1, double number2)
        {
            if (number1 > 0 && (double.MaxValue / number2) < number2)
            {
               return false;
            }
            return true;

        }

        private Boolean IsDivision(double number1, double number2)
        {
            if ((int) number1 == 0 && (int) number2 == 0)
            {
                _beyondScope = "Result is undefined";
                return false;
            }
            if ((int) number2 == 0)
            {
                _beyondScope = "Cannot divide by zero";
                return false;
            }
            return true;
        }

      
            public
            string GetOutput()

            {
                string getString;
           
                if (_beyondScope.Length > 0)
            {
                getString = _beyondScope;
                _beyondScope = "";
            }
            else if (_isWaitingForSecondOperator)
                getString = _currentValue.ToString();
            else getString = _previousValue.ToString();
           
            return getString;
        }
    }
}