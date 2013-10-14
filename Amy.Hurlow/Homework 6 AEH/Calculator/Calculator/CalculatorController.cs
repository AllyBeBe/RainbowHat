using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Calculator
{
    public class CalculatorController
    {
        // the static keyword -- examples
//        private static string _onlyOneCopyForAllInstances = "Sally";
//
//        private static int multiply(int x, int y)
//        {
//            return x * y;
//        }

        private string _firstNumberEntered; // The first number in the calculation (before the first operator)
        private string _secondNumberEntered; // The number after the first operator
        private string _firstValidOperator; // "valid" if it's the last operator in a sequence of operators entered (first operation)
        private string _answer; // The result of doing the math on "equals"
        private string _display;
        private bool _digitsEnteredShouldGoIntoFirstNumber; // True if we're entering the first number, false if we're entering the second or third.
        private bool _digitsEnteredShouldGoIntoSecondNumber;
        private bool _justCleared = false;

        // Static variables are shared by all instances of the class, and are only initialized once, 
        // when the class is first loaded. 
        // Readonly variables can only have their value set once, when they are first initialized, in
        // an initializer statement or in a constructor.  The "readonly" keyword helps to indicate that 
        // you don't expect a value to ever be changed.
        private static readonly Collection<string> Digits = new Collection<string>
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"
        };

        private static readonly Collection<string> Operators = new Collection<string> {"+", "-", "*", "/"};



        public CalculatorController()
        {
            Clear();

        }

        public void Clear()
        {
            _firstNumberEntered = "0";
            _secondNumberEntered = String.Empty;
            _firstValidOperator = String.Empty;
            _display = "0";
            _answer = String.Empty;
            _digitsEnteredShouldGoIntoFirstNumber = true;
            _digitsEnteredShouldGoIntoSecondNumber = true;
            _justCleared = true;


        }


        public void AcceptCharacter(char inputChar)
        {
            string input = inputChar.ToString();


            if (input == "c")
            {
                Clear();
            }

            if ((_justCleared) && input == "-")
                MakeFirstNumberNegative();
            else
            {
                _justCleared = false;

                if (Digits.Contains(input))
                    // TODO: CHANGE THIS SO IT CAN TAKE AN INFINITE NUMBER OF OPERATIONS AND NUMBERS? DEPENDS ON IF I CAN USE THE VALUE OF A VAR IN THE NAME OF ANOTHER VAR.
                {
                    if (_digitsEnteredShouldGoIntoFirstNumber)
                    {
                        _firstNumberEntered = AppendDigit(_firstNumberEntered, input);
                        _display = _firstNumberEntered;
                    }
                    else if (_digitsEnteredShouldGoIntoSecondNumber)
                    {
                        _secondNumberEntered = AppendDigit(_secondNumberEntered, input);
                        _display = _secondNumberEntered;
                    }

                }
                else if (Operators.Contains(input))
                    //TODO SAME QUESTION AS FOR DIGITS.  WANT TO ALLOW AN INFINITE NUMBER OF numbers and operators.
                {
                    if (_firstValidOperator == (String.Empty))
                    {
                        _firstValidOperator = input;
                        _digitsEnteredShouldGoIntoFirstNumber = false;
                    }

                }
                else if (input == "=")
                {
                    if (_firstValidOperator == "+")
                    {
                        _answer =
                            (double.Parse(_firstNumberEntered) + double.Parse(_secondNumberEntered)).ToString();
                    }
                    else if (_firstValidOperator == "-")
                    {
                        _answer =
                            (double.Parse(_firstNumberEntered) - double.Parse(_secondNumberEntered)).ToString();
                    }
                    else if (_firstValidOperator == "*")
                    {
                        _answer = (double.Parse(_firstNumberEntered)*double.Parse(_secondNumberEntered)).ToString();
                    }
                    else if (_firstValidOperator == "/")
                        if (_secondNumberEntered == "0")
                            if (double.Parse(_firstNumberEntered) == 0.0)
                            {
                                _answer = "Result is undefined";
                            }
                            else
                            {
                                _answer = "Cannot divide by zero";
                            }
                        else
                            _answer =
                                (double.Parse(_firstNumberEntered)/double.Parse(_secondNumberEntered)).ToString();
                }
            }
        }


        private string AppendDigit(string existingNumber, string digit)
        {
            if (existingNumber == "0")
            {
                return digit;
            }
            if (existingNumber != null && existingNumber.Length == 15) // Checked for null because "null reference" error unhandled. How could existingNumber get to be null?
            {
                return existingNumber;
            }
            return existingNumber + digit;
        }

        private string MakeFirstNumberNegative()
            {
                _firstNumberEntered = "-" + _firstNumberEntered; 
                return _firstNumberEntered;
            }


        public string GetOutput()
        {
            if (_answer == String.Empty)
            {
                return _display;
            }
            {
                return _answer;
            }
        }
    }
}

// Pseudocode and notes for AcceptCharacter() :
// For simplicity, assuming user inputs only these, in this order: number, operator, number, equals.
// (Later, when user can enter anything in any order, will I have to keep track of each input in order for each round until equals?)
// 1. Take input until equals is the input.
//      A Input is 0-9:
//          Is this the first or second number entered? How to tell?  Try "Is there something in Operator?" (this eventually won't work as a check.  what if user hits an operator as his first key?)
//              If no, store or append input in NE1
//              If yes, store or append input in NE2
//
//                  Was NE1/NE2 (whichever we're about to store in) empty?
//                      If yes,
//                          Store input in NE.
//                          Go back and take more input.
//                      If no,
//                          Append input to what's in NE.
//                          Go back and take more input.
//      B Input is Operator
//          Store input in Operator
//
// 2. If input is equals, "do the math": 
//      convert strings in the vars to decimals
//      convert the operator string to a math operator
//      combine them to produce a math (decimal) answer
//      store the answer in Answer as a string


// At some future point, some other piece of code may call GetOutput(), which will
// return the value of _answer.  That other piece of code may display that value 
// in a TextBox, or compare it to an "expected" value in a test.  But all GetOutput()
// needs to do is return the value of _answer.
