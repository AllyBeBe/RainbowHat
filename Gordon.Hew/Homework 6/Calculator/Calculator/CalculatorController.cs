using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private const string ZeroString = "0";

        private const string DivideNanMessage = "Result is undefined";

        private const string DivideInfinityMessage = "Cannot divide by zero";
        
        private char _operator;

        /*TODO: these should be domain objects, oh well... */

        private String _inputCurrent;

        private double _inputCurrentDouble;

        private String _inputPrevious;

        private double _inputPreviousDouble;

        private String _outputValue;

        private int _inputCurrentDigitCounter;

        private double _result;

        private String _debugString;

        public CalculatorController()
        {
            Init();
        }

        private void Init()
        {
            _operator = ' ';
            _inputCurrent = String.Empty;
            _inputCurrentDouble = 0;
            _inputPrevious = String.Empty;
            _inputPreviousDouble = 0;
            _outputValue = ZeroString;
            _inputCurrentDigitCounter = 0;
            _debugString = String.Empty;
            _result = Double.NaN;
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            _debugString += input;

            Console.WriteLine(_debugString);
            
            if ('c' == input)
            {
                Console.WriteLine("CLEAR");
                Init();
            }
            else if (IsValidInputNumber(input))
            {
                Console.WriteLine("IsValidInputNumber");
                /* Ignore attempts to add leading zeroes */
                if (!IsAddingLeadingZero(input))
                {
                    /* Replace value wholesale if previous value is zero */
                    if (IsReplaceZero(input))
                    {
                        _inputCurrent = input.ToString(CultureInfo.InvariantCulture);
                        _outputValue = _inputCurrent;
                    }
                    else
                    {
                        if (_inputCurrentDigitCounter < 15)
                        {
                            _inputCurrent += input;

                            /* do not display the negative sign if we are still constructing the number */
                            _outputValue = "-".Equals(_inputCurrent) ? ZeroString : _inputCurrent.Replace("-", "");

                            if (Char.IsDigit(input))
                                _inputCurrentDigitCounter++;
                        }
                    }
                }
            }
            else if ('=' == input)
            {
                Console.WriteLine("EQUALS");
                Console.WriteLine("PRE: " + _inputPreviousDouble + " " + _operator + " " + _inputCurrent + "=");

                if(String.IsNullOrEmpty(_inputCurrent))
                    _inputCurrent = _inputPrevious;

                _inputCurrentDouble =  Double.Parse(_inputCurrent);

                var left = !Double.IsNaN(_result) ? _result : _inputPreviousDouble;
                var right = _inputCurrentDouble;

                Console.WriteLine("PRE2: " + left + " " + _operator + " " + right + "=");

                switch (_operator)
                {
                    case '+':
                    {
                        _result = left + right;
                        _outputValue = _result.ToString("G");
                        break;
                    }
                    case '-':
                    {
                        _result = left - right;
                        _outputValue = _result.ToString("G");
                        break;
                    }
                    case '/':
                    {
                        _result = left / right;

                        if (Double.IsNaN(_result))
                            _outputValue = DivideNanMessage;
                        else if (Double.IsInfinity(_result))
                            _outputValue = DivideInfinityMessage;
                        else
                            _outputValue = _result.ToString("G");

                        break;
                    }
                    case '*':
                    {
                        _result = left * right;
                        _outputValue = _result.ToString("G");
                        break;
                    }
                    default:
                    {
                        _result = right;
                        _outputValue = _result.ToString("G");
                        break;
                    }
                }

                Console.WriteLine("POST: " + _inputPreviousDouble.ToString("G") + _operator + _inputCurrentDouble.ToString("G") + "=" + _result.ToString("G"));

                /*_inputPrevious = result.ToString("G");
               _inputPreviousDouble = result;
               
                               _inputCurrent = String.Empty;
                               _inputCurrentDouble = 0; */
                _inputCurrentDigitCounter = 0;
              
                //_operator = ' ';
            }
            else
            {
                Console.WriteLine("ELSE");
                
                _operator = input;
                _inputPrevious = _inputCurrent;
                _inputPreviousDouble = String.Empty.Equals(_inputPrevious) ? 0 : Double.Parse(_inputPrevious);
                
                _inputCurrent = String.Empty;
                _inputCurrentDouble = 0;
                _inputCurrentDigitCounter = 0;
            }
        }

        public string GetOutput()
        {
            return _outputValue;
        }

        private bool IsValidInputNumber(char input)
        {
            /* Checks if the value is a digit, decimal point, or the start of a negative number */
            return Char.IsDigit(input) || input == '.' || String.Empty.Equals(_inputCurrent) && input == '-'; ;
        }

        private bool IsAddingLeadingZero(char input)
        {
            return input == '0' && _inputCurrent.Equals(ZeroString);
        }

        private bool IsReplaceZero(char input)
        {
            return ZeroString.Equals(_inputCurrent);
        }
    }
}
