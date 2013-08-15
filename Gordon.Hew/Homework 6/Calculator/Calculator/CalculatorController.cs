using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private char _operator;

        private String _inputCurrent;

        private String _inputPrevious;

        private String _outputValue;

        public CalculatorController()
        {
            _operator = ' ';
            _inputCurrent = "";
            _inputPrevious = "";
            _outputValue = "0";
        }

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            if ('c' == input)
            {
                _inputCurrent = "";
                _outputValue = "0";
                _operator = ' ';
            }
            else if (Char.IsDigit(input) || input == '.' || (String.Empty.Equals(_inputCurrent) && input == '-'))
            {
                _inputCurrent += input;
                _outputValue = _inputCurrent;                
            }
            else if ('=' == input)
            {
                decimal result = 0;
                decimal lastInputValue = Convert.ToDecimal(_inputPrevious);
                decimal currentInputValue = Convert.ToDecimal(_inputCurrent);

                switch (_operator)
                {
                    case '+':
                    {
                        result = lastInputValue + currentInputValue;
                        break;
                    }
                    case '-':
                    {
                        result = lastInputValue - currentInputValue;
                        break;
                    }
                    case '/':
                    {
                        result = lastInputValue/currentInputValue;
                        break;
                    }
                    case '*':
                    {
                        result = lastInputValue*currentInputValue;
                        break;
                    }
                    default:
                    {
                        result = lastInputValue;
                        break;
                    }
                }

                Console.WriteLine(lastInputValue + " " + _operator + " " + currentInputValue + " = " + result);

                _outputValue = result.ToString();
                _inputPrevious = result.ToString();

                Console.WriteLine(lastInputValue + " " + _operator + " " + currentInputValue + " = " + _inputPrevious);
                
                _operator = ' ';


            }
            else
            {
                _operator = input;
                _inputPrevious = _inputCurrent;
                _inputCurrent = "";
            }
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            if("-".Equals(_outputValue))
                return "0";

            return _outputValue;
        }
    }
}
