using System;
using System.ComponentModel;
using System.Linq;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private double _previousValue = 0;
        private Operator _currentOperator = Operator.None;
        private double _currentValue = 0;
        private string _error;

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            switch (input)
            {
                case 'c':
                {
                    _previousValue = 0;
                    _currentOperator = Operator.None;
                    _currentValue = 0;
                    _error = null;
                    break;
                }
                case '=':
                {
                    _previousValue = (_currentOperator == Operator.None) ? _currentValue : Calculate();
                    _currentValue = 0;
                    break;
                }
                case '+':
                case '-':
                case '*':
                case '/':
                {
                    _previousValue = (_currentOperator == Operator.None) ? _currentValue : Calculate();
                    _currentValue = 0;
                    _currentOperator = GetOperatorForChar(input);
                    break;
                }
                default:
                {
                    if (_currentValue.ToString().Length < 15) {
                        _currentValue = _currentValue*10 + int.Parse(input.ToString());
                    }
                    break;
                }
            }
        }

        private double Calculate()
        {
            switch (_currentOperator)
            {
                case Operator.Plus: return _previousValue + _currentValue;
                case Operator.Minus: return _previousValue - _currentValue;
                case Operator.Times: return _previousValue * _currentValue;
                case Operator.Divide:
                    if (_currentValue == 0)
                    {
                        _error = (_previousValue == 0) ? "Result is undefined" : "Cannot divide by zero";
                        return _previousValue;
                    }
                    return _previousValue/_currentValue;
                default: throw new Exception("Unrecognized operator " + _currentOperator);
            }
        }

        private Operator GetOperatorForChar(char operatorChar)
        {
            switch (operatorChar)
            {
                case '+': return Operator.Plus;
                case '-': return Operator.Minus;
                case '*': return Operator.Times;
                case '/': return Operator.Divide;
                default: throw new Exception("Unrecognized operator " + operatorChar);
            }
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            return _error ?? (_currentValue != 0 ? _currentValue.ToString() : _previousValue.ToString());
        }
    }

    internal enum Operator
    {
        None,
        Plus,
        Minus,
        Times,
        Divide
    }
}
