using System;
using System.Collections.ObjectModel;

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
        private string _thirdNumberEntered; // TODO: But what if the user wants to enter many operations and numbers (more than 3)?
        private string _firstValidOperator; // "valid" if it's the last operator in a sequence of operators entered (first operation)
        private string _secondValidOperator; // after second number 
        private string _answer; // The result of doing the math on "equals"
        private string _display;

        private bool _digitsEnteredShouldGoIntoFirstNumber; // True if we're entering the first number, false if we're entering the second or third.
        private bool _digitsEnteredShouldGoIntoSecondNumber;
        private bool _digitsEnteredShouldGoIntoThirdNumber; 
        private bool _operatorIsEnteredAfterSecondNumber; // True if user enters three numbers and tries multiple operations before equals


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

        // Defines a method to clear the variables. 
        // Called before each test. Where else do I need it?
        public void Clear()
        {


            _firstNumberEntered = "0";
            _secondNumberEntered = String.Empty;
            _firstValidOperator = String.Empty;
            _secondValidOperator = String.Empty;
            _display = "0";
            _answer = String.Empty;
            _digitsEnteredShouldGoIntoFirstNumber = true;
            _digitsEnteredShouldGoIntoSecondNumber = true;
            _digitsEnteredShouldGoIntoThirdNumber = true;// todo: I might not need a variable if should go into 3rd number
            _operatorIsEnteredAfterSecondNumber = false;

        }

        public void AcceptCharacter(char inputChar) 
        {
            string input = inputChar.ToString();

            if (input == "c")
            {
                Clear();

            }
            else if (Digits.Contains(input))
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
                else if (_digitsEnteredShouldGoIntoThirdNumber)
                {
                    _thirdNumberEntered = AppendDigit(_thirdNumberEntered, input);
                    _display = _secondNumberEntered;     
                }
            }
            else if (Operators.Contains(input))
            {
                _firstValidOperator = input;
                //TODO This should be where now?
                _digitsEnteredShouldGoIntoFirstNumber = false;
                {
                    if (_secondNumberEntered != String.Empty)
                    {
                        _digitsEnteredShouldGoIntoSecondNumber = false;
                    }
                    if (_thirdNumberEntered != String.Empty)
                        _digitsEnteredShouldGoIntoThirdNumber = false;
                }
            }
            else if (input == "=")
            {
                if (_firstValidOperator == "+")
                {
                    _answer = (double.Parse(_firstNumberEntered) + double.Parse(_secondNumberEntered)).ToString();
                }
                else if (_firstValidOperator == "-")
                {
                    _answer = (double.Parse(_firstNumberEntered) - double.Parse(_secondNumberEntered)).ToString();
                }
                else if (_firstValidOperator == "*")
                {
                    _answer = (double.Parse(_firstNumberEntered) * double.Parse(_secondNumberEntered)).ToString();
                }
                else if (_firstValidOperator == "/")
                {
                    if (_secondNumberEntered == "0")
                        switch (_firstNumberEntered)
                        {
                            case "0":
                                _answer = "Result is undefined";
                                break;
                            default:
                                _answer = "Cannot divide by zero";
                                break;
                        }
                    else
                    _answer = (double.Parse(_firstNumberEntered)/double.Parse(_secondNumberEntered)).ToString();
                }
            }
        }

        private string AppendDigit(string existingNumber, string digit)
        {
            if (existingNumber == "0")
            {
                return digit;
            }
            if (existingNumber.Length == 15)
            {
                return existingNumber;
            }
            return existingNumber + digit;
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
