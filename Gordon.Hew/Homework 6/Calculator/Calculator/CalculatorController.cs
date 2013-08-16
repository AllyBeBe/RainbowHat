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
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            if ('c' == input)
            {
                Init();
            }
            else if (IsValidInputNumber(input))
            {
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
                            _outputValue = _inputCurrent;

                            if (Char.IsDigit(input))
                                _inputCurrentDigitCounter++;
                        }
                    }
                }
            }
            else if ('=' == input)
            {
                _inputCurrentDouble = Double.Parse(_inputCurrent);

                double result = 0;

                switch (_operator)
                {
                    case '+':
                    {
                        result = _inputPreviousDouble + _inputCurrentDouble;
                        _outputValue = result.ToString("G");
                        break;
                    }
                    case '-':
                    {
                        result = _inputPreviousDouble - _inputCurrentDouble;
                        _outputValue = result.ToString("G");
                        break;
                    }
                    case '/':
                    {
                        result = _inputPreviousDouble / _inputCurrentDouble;

                        if (Double.IsNaN(result))
                            _outputValue = DivideNanMessage;
                        else if (Double.IsInfinity(result))
                            _outputValue = DivideInfinityMessage;
                        else
                            _outputValue = result.ToString("G");

                        break;
                    }
                    case '*':
                    {
                        result = _inputPreviousDouble * _inputCurrentDouble;
                        _outputValue = result.ToString("G");
                        break;
                    }
                    default:
                    {
                        result = _inputCurrentDouble;
                        _outputValue = result.ToString("G");
                        break;
                    }
                }

                Console.WriteLine(_inputPreviousDouble.ToString("G") + " " + _operator + " " + _inputCurrentDouble.ToString("G") + "=" + result.ToString("G"));
               
                _inputPrevious = result.ToString("G");
                _inputCurrentDigitCounter = 0;
                _operator = ' ';
            }
            else
            {
                _operator = input;
                _inputPrevious = _inputCurrent;
                _inputPreviousDouble = Double.Parse(_inputPrevious);
                _inputCurrent = String.Empty;
                _inputCurrentDouble = 0;
                _inputCurrentDigitCounter = 0;
            }
        }

        public string GetOutput()
        {
            return _outputValue;
        }

        private Boolean IsValidInputNumber(char input)
        {
            /* Checks if the value is a digit, decimal point, or the start of a negative number */
            return Char.IsDigit(input) || input == '.' || String.Empty.Equals(_inputCurrent) && input == '-'; ;
        }

        private Boolean IsAddingLeadingZero(char input)
        {
            return input == '0' && _inputCurrent.Equals(ZeroString);
        }

        private Boolean IsReplaceZero(char input)
        {
            return ZeroString.Equals(_inputCurrent);
        }

        private Boolean IsUnaryOperation(char input)
        {
            return false;
        }
    }
}
