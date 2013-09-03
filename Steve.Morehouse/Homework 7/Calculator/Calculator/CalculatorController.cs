using System;

namespace Calculator
{
    public class CalculatorController
    {
        /*
         * the maximum number of characters to be displayed
         */
        private const int MAXDISPLAYCHARACTERS = 15;
        private const int MAX_PRECISION = 17;

        // nullable types
        private double? _previousValue;
        private double? _currentValue;
        private double? _lastValue;
        private double? _resultValue;

        private char? _previousOperator;
        private char? _currentOperator;

        private char? _equalityOperator;
        private bool _expectDuplicateOperatorInput;
        private bool _useImplicitZero;

        // new
        private string _errorMessage;

        public CalculatorController()
        {
            clear();
        }

        private void clear()
        {
            _previousValue = null;
            _currentValue = 0;
            _previousOperator = null;
            _currentOperator = null;
            _equalityOperator = null;
            _expectDuplicateOperatorInput = false;
            _errorMessage = null;
            _resultValue = 0;
            _useImplicitZero = true;
        }

        public void AcceptCharacter(char input)
        {
            if (_errorMessage != null && input != 'c')
                return;

            switch (input)
            {
                case 'c':
                case 'C':
                    clear();
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    numberEntered(input);
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    ProcessOperatorInput(input);
                    break;
                case '=':
                    equalsEntered(input);
                    break;
            }
        }

        private void equalsEntered(char input)
        {
            if (!_useImplicitZero)
            {
                _currentValue = _lastValue;
            }
            _equalityOperator = input;
            _previousOperator = _currentOperator;

            DoMath();
            _previousValue = _resultValue;
            _expectDuplicateOperatorInput = true;
        }

        private void ProcessOperatorInput(char input)
        {
            _useImplicitZero = false;
            _equalityOperator = null;
            _currentOperator = input;

            if (!_expectDuplicateOperatorInput)
            {
                if (_previousOperator.HasValue && _previousValue.HasValue)
                {
                    DoMath();
                    _lastValue = _resultValue;
                }
            }
            _previousValue = _resultValue;
            _currentValue = 0;
            _previousOperator = _currentOperator;
            _expectDuplicateOperatorInput = true;
        }

        private void numberEntered(char input)
        {
            _useImplicitZero = true;
            _expectDuplicateOperatorInput = false;
            if (_equalityOperator.HasValue)
            {
                clear();
            }
            if (_currentValue.ToString().Length < MAXDISPLAYCHARACTERS)
            {
                _currentValue = Double.Parse(_currentValue.ToString() + input.ToString());
                _lastValue = _currentValue;
                _resultValue = _currentValue;
            }
        }

        private void DoMath()
        {
            switch (_previousOperator)
            {
                case '+':
                    _resultValue = _previousValue + _currentValue;
                    return;
                case '-':
                    _resultValue = _previousValue - _currentValue;
                    return;
                case '*':
                    _resultValue = _previousValue * _currentValue;
                    return;
                case '/':
                    if (_previousValue == 0 && _currentValue == 0)
                        _errorMessage = "Result is undefined";
                    else if (_currentValue == 0)
                        _errorMessage = "Cannot divide by zero";
                    else
                        _resultValue = _previousValue / _currentValue;
                    return;
            }
        }

        public string GetOutput()
        {
            if (_errorMessage != null)
                return _errorMessage;

            var firstSignificantDigitMultiplier = 1;
            if (_resultValue != 0)
            {
                var resultExponent = Math.Ceiling(Math.Log10((double)_resultValue));
                if (resultExponent < 0)
                    firstSignificantDigitMultiplier = (int)Math.Pow(10, -1 * resultExponent);
            }
            var precision = MAX_PRECISION - ((long)_resultValue).ToString().Length - 1;//-1 for comma
            string result = (precision > 0) ?
                (Math.Round((double)_resultValue * firstSignificantDigitMultiplier, precision) /
                firstSignificantDigitMultiplier).ToString()
                : _resultValue.ToString();
            return result;
        }
    }
}
