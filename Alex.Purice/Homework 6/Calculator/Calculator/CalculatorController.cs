using System;
using System.Data;
using System.Linq.Expressions;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private const int CurrentValueMaxPresicion = 17;
        private double? _previousValue;
        private double? _currentValue;
        private double? _lastValue;
        private double? _resultValue;

        private char? _previousOperator;
        private char? _currentOperator;

        private char? _equalityOperator;
        private bool _expectDuplicateOperatorInput;
        private bool _useImplicitZero;
        private string _errorMessage;

        public CalculatorController()
        {
            ResetController();
        }

        private void ResetController()
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
                    ResetController();
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
                    ProcessDigitInput(input);
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    ProcessOperatorInput(input);
                    break;
                case '=':
                    ProcessEquationSignInput(input);
                    break;
            }
        }

        private void ProcessEquationSignInput(char input)
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
                }
            }
            _previousValue = _resultValue;
            _currentValue = 0;
            _previousOperator = _currentOperator;
            _expectDuplicateOperatorInput = true;
        }

        private void ProcessDigitInput(char input)
        {
            _useImplicitZero = true;
            _expectDuplicateOperatorInput = false;
            if (_equalityOperator.HasValue)
            {
                ResetController();
            }
            if (_currentValue.ToString().Length < 15)
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
            var precision = CurrentValueMaxPresicion - ((long)_resultValue).ToString().Length - 1;//-1 for comma
            string result = (precision > 0)?Math.Round((double)_resultValue, precision).ToString():_resultValue.ToString();
            return result;
        }
    }
}
