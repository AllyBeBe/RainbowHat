using System;
using System.Data;
using System.Linq.Expressions;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private const int CurrentValueMaxPresicion = 16;
        private decimal? _previousValue = null;
        private decimal? _currentValue = 0;

        private char? _previousOperator = null;
        private char? _currentOperator = null;

        private char? _equalityOperator = null;

        private bool _clearCurrentValue = false;

        private short _currentValueSign = 1;


        //For ome unknown reason constructor doesn't work
        public void CalculatorConroller()
        {
            ResetContorller();
        }

        private void ResetContorller()
        {
            _previousValue = null;
            _currentValue = 0;
            _previousOperator = null;
            _currentOperator = null;
            _equalityOperator = null;
            _clearCurrentValue = false;
            _currentValueSign = 1;
        }

        public void AcceptCharacter(char input)
        {
            //temporary fix for "not runable" constructor
            if (_currentValueSign == 0)
                _currentValueSign = 1;

            switch (input)
            {
                case 'c':
                case 'C':
                    ResetContorller();
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
                    if (_currentOperator.HasValue & _equalityOperator.HasValue)
                    {
                        ResetContorller();
                    }
                    if (_clearCurrentValue)
                    {
                        _currentValue = 0;
                        _clearCurrentValue = false;
                    }
                    if (_currentValue.ToString().Length < 15)
                    {
                        _currentValue = Decimal.Parse(_currentValue.ToString() + input.ToString()) * _currentValueSign;
                    }
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    _currentValueSign = 1;
                    if (_currentValue.HasValue)
                    {
                        _clearCurrentValue = true;
                        _currentOperator = input;
                    }
                    else
                    {
                        if (input == '-')
                        {
                            _currentValueSign = -1;
                        }
                    }
                    if (_previousOperator.HasValue)
                    {
                        DoMath();
                    }
                    else if (_currentValue.HasValue)
                    {
                        _previousValue = _currentValue;
                    }
                    if (_currentOperator.HasValue)
                    {
                        _previousOperator = _currentOperator;
                    }
                    break;
                case '=':
                    if (!_currentOperator.HasValue)
                    {
                        return;
                    }
                    _equalityOperator = input;
                    if (!_previousOperator.HasValue & !_previousValue.HasValue)
                    {
                        _currentValue = _previousValue;
                    }
                    DoMath();
                    break;
            }
        }

        private void DoMath()
        {
            switch (_currentOperator)
            {
                case '+':
                    _currentValue = _previousValue + _currentValue;
                    return;
                case '-':
                    _currentValue = _previousValue - _currentValue;
                    return;
                case '*':
                    _currentValue = _previousValue * _currentValue;
                    return;
                case '/':
                    _currentValue = _previousValue / _currentValue;
                    return;
            }
            //DataTable dataTable = new DataTable();
            //_currentValue = (decimal?) dataTable.Compute(_previousValue.ToString() + _currentOperator.ToString() + _currentValue.ToString(),"");
        }

        public string GetOutput()
        {
            var _precision = CurrentValueMaxPresicion - ((int)_currentValue).ToString().Length - 1;//-1 for comma
            return Math.Round((decimal)_currentValue, _precision).ToString();
        }
    }
}
