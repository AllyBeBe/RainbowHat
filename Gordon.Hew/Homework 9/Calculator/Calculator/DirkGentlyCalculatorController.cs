using System;
using System.Globalization;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class DirkGentlyCalculatorController
    {
        private const string ZeroString = "0";
        private const string DivideNanMessage = "Result is undefined";

        private char _operator;
        private char _lastInput;

        private String _inputCurrent;
        private String _inputPrevious;
        private String _outputValue;

        private double _inputCurrentDouble;
        private double _inputPreviousDouble;
        private double _result;

        private int _inputCurrentDigitCounter;

        private bool _justCalculated;

        public DirkGentlyCalculatorController()
        {
            Init();
        }

        public void Init()
        {
            _operator = ' ';
            _inputCurrent = String.Empty;
            _inputCurrentDouble = 0;
            _inputPrevious = String.Empty;
            _inputPreviousDouble = 0;
            _outputValue = ZeroString;
            _inputCurrentDigitCounter = 0;
            _result = Double.NaN;
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            _justCalculated = false;

            if ('c' == input)
            {
                Init();
            }
            else if (IsFunction(input))
            {
                ProcessFunction(input);
            }
            else if (IsValidInputNumber(input))
            {
                ProcessNumber(input);
            }
            else if ('=' == input)
            {
                ProcessEquals();
            }
            else
            {
                ProcessOperator(input);
            }

            _lastInput = input;
        }

        public string GetOutput()
        {
            return _outputValue;
        }

        public bool GetJustCalculated()
        {
            return _justCalculated;
        }

        private bool IsValidInputNumber(char input)
        {
            /* Checks if the value is a digit, decimal point, or the start of a negative number */
            return Char.IsDigit(input) || input == '.' ||
                   (String.Empty.Equals(_inputCurrent) && input == '-' && !IsOperator(_lastInput));
        }

        private bool IsAddingLeadingZero(char input)
        {
            return input == '0' && _inputCurrent.Equals(ZeroString);
        }

        private static bool IsReplaceZero(String input)
        {
            return ZeroString.Equals(input);
        }

        private static double Calculate(char input, double left, double right)
        {
            double result;

            switch (input)
            {
                case '+':
                {
                    result = left + right;
                    break;
                }
                case '-':
                {
                    result = left - right;
                    break;
                }
                case '/':
                {
                    result = left/right;
                    break;
                }
                case '*':
                {
                    result = left*right;
                    break;
                }
                default:
                {
                    result = left + right;
                    break;
                }
            }

            return result;
        }

        private static bool IsOperator(char input)
        {
            switch (input)
            {
                case '+':
                {
                    return true;
                }
                case '-':
                {
                    return true;
                }
                case '/':
                {
                    return true;
                }
                case '*':
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }

        private static bool IsFunction(char input)
        {
            switch (input)
            {
                case 's':
                {
                    return true;
                }
                case 'o':
                {
                    return true;
                }
                case 't':
                {
                    return true;
                }
                case 'q':
                {
                    return true;
                }
                case 'r':
                {
                    return true;
                }
                case '%':
                {
                    return true;
                }
                case '#':
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }

        private void ProcessNumber(char input)
        {
            if (_lastInput == '=')
                Init();

            /* Ignore attempts to add leading zeroes */
            if (!IsAddingLeadingZero(input))
            {
                /* Replace value wholesale if previous value is zero */
                if (IsReplaceZero(_inputCurrent))
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

        private void ProcessEquals()
        {
            if (String.IsNullOrEmpty(_inputPrevious))
                _inputPrevious = ZeroString;

            if (String.IsNullOrEmpty(_inputCurrent))
                _inputCurrent = _inputPrevious;

            _inputPreviousDouble = Double.Parse(_inputPrevious);
            _inputCurrentDouble = Double.Parse(_inputCurrent);

            var left = !Double.IsNaN(_result) ? _result : _inputPreviousDouble;
            var right = _inputCurrentDouble;

            _result = Calculate(_operator, left, right);
            _outputValue = ProcessResult(_result);

            _inputCurrentDigitCounter = 0;
            _justCalculated = true;
        }

        private void ProcessOperator(char input)
        {
            if (IsOperator(_lastInput))
            {
                _operator = input;
            }
            else
            {
                if (!String.IsNullOrEmpty(_inputPrevious) && !String.IsNullOrEmpty(_inputCurrent))
                {
                    _inputCurrentDouble = Double.Parse(_inputCurrent);
                    _result = Calculate(_operator, _inputPreviousDouble, _inputCurrentDouble);

                    _inputCurrent = _result.ToString("G");
                    _outputValue = _inputCurrent;
                    _justCalculated = true;
                }

                _operator = input;
                _inputPrevious = _inputCurrent;
                _inputPreviousDouble = String.Empty.Equals(_inputPrevious) ? 0 : Double.Parse(_inputPrevious);

                _inputCurrent = String.Empty;
                _inputCurrentDouble = 0;
                _inputCurrentDigitCounter = 0;

                _outputValue = _inputPrevious;
            }
        }

        private String ProcessResult(double result)
        {
            return Double.IsNaN(result) ? DivideNanMessage : result.ToString("G");
        }

        private void ProcessFunction(char input)
        {
            _inputCurrentDouble = String.IsNullOrEmpty(_inputCurrent) ? 0 : Double.Parse(_inputCurrent);
            _result = CalculateFunction(input, _inputCurrentDouble);
            _outputValue = ProcessResult(_result);
            _inputCurrent = _outputValue;

            _inputCurrentDigitCounter = 0;
            _justCalculated = true;
        }

        private static double CalculateFunction(char function, double input)
        {
            double result;

            switch (function)
            {
                case 's':
                {
                    result = Math.Sin(input);
                    break;
                }
                case 'o':
                {
                    result = Math.Cos(input);
                    break;
                }
                case 't':
                {
                    result = Math.Tan(input);
                    break;
                }
                case 'q':
                {
                    result = input * input;
                    break;
                }
                case 'r':
                {
                    result = 1 / input;
                    break;
                }
                case '#':
                {
                    result = -1 * input;
                    break;
                }
                default:
                {
                    result = input;
                    break;
                }
            }

            return result;
        }
    }
}