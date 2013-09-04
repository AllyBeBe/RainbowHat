using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {

        private String _operator = "";
        private int _currentValue = 0;
        private String _currentInput = "";
        private int _firstNumber = 0;
        private int _secondNumber = 0;
        private bool _firstBool = false;
        private bool _secondBool = false;
        private bool _negative = false;
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.

        public int Operate(int number1, int number2, String operators)
        {
            switch (operators)
            {
                case "+" :
                {
                    return number1 + number2;
                }
                case "-":
                {
                    return number1 - number2;
                }
                case "/":
                {
                    return number1 / number2;
                }
                case "*":
                {
                    return number1 * number2;
                }
                default:
                    return 0;
            }
        }

        public void AcceptCharacter(char input)
        {
            // Your code will eventually go here, to make all of the tests pass.

            // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!.
            if (input == 'c' || input == 'C')
            {
                _currentInput = "";
                _currentValue = 0;
                _firstBool = false;
                _secondBool = false;
            }
            else if (input == '+')
            {
                _operator = "+";
                if (_secondBool)
                {
                    _currentValue = Operate(_firstNumber, _secondNumber, _operator);
                    _firstBool = false;
                    _secondBool = false;
                    _firstNumber = 0;
                    _secondNumber = 0;
                    _currentInput = "";
                }
                else if (_firstBool)
                {
                     //_firstBool = true;
                    _secondNumber = int.Parse(_currentInput);
                    _secondBool = true;
                    _currentInput = "";
                }
                else
                {
                    _firstBool = true;
                    _firstNumber = int.Parse(_currentInput);
                    _currentInput = "";
                }
            }
            else if (input == '-')
            {
                _operator = "-";
                if (_secondBool)
                {
                    _currentValue = Operate(_firstNumber, _secondNumber, _operator);
                    _firstBool = false;
                    _secondBool = false;
                    _firstNumber = 0;
                    _secondNumber = 0;
                    _currentInput = "";
                }
                else if (_firstBool)
                {
                    //_firstBool = true;
                    _secondNumber = int.Parse(_currentInput);
                    _secondBool = true;
                    _currentInput = "";
                }
                else if (_currentInput == "")
                { 
                    _firstBool = true;
                    _firstNumber = 0;
                }
                else
                {
                    _firstBool = true;
                    _firstNumber = int.Parse(_currentInput);
                    _currentInput = "";
                }
            }
            else if (input == '=')
            {
                if (_firstBool)
                {
                    //_firstBool = true;
                    _secondNumber = int.Parse(_currentInput);
                    _currentInput = "";
                    _currentValue = Operate(_firstNumber, _secondNumber, _operator);
                }
                else
                {
                    _firstBool = true;
                    _currentValue = int.Parse(_currentInput);
                    _currentInput = "";

                }

                _secondBool = false;
                _secondNumber = 0;
                
            }
            /*else if ()
            {
            }
            else if ()
            {
            }*/
            else
            {
                _currentInput += char.ToString(input);
            }

        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            /*if (_firstBool)
            {
                //_firstBool = true;
                _secondNumber = int.Parse(_currentInput);
                _currentInput = "";
                _currentValue = _firstNumber + _secondNumber;
            }
            else
            {
                _currentValue = _currentInput.Length != 0 ? int.Parse(_currentInput) : 0;
                _currentInput = "";
            }*/

            _currentValue = _currentInput.Length != 0 ? int.Parse(_currentInput) : _currentValue;

            return _currentValue.ToString();
        }
    }
}
