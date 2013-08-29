using System;
using System.Collections.ObjectModel;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        // Create and initialize variables.  This happens first whenever calculator is started.
        private int _currentValue = 0; // Mickey put this in
        private string _numberEntered1 = String.Empty; // The first number in the calculation (before the first operator)
        private string _numberEntered2 = String.Empty; // The number after the first operator
        private string _operator = String.Empty;   // the last operator entered (should ignore any operators entered immediately before)
        private string _answer = String.Empty; // The result of doing the math on "equals"

        // Create a collection of integers, zero through 9
                
        Collection<string> numberbuttons = new Collection<string>{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
    

        // Create a collection of strings of the operators: 
            {
                Collection<string> operators = new Collection<string>{'+', '-', '*', '/'};
            }

        // Defines a method to clear the variables. 
        // Called before each test. AMY Where else do I need it?
        public void Clear()
        {
            _currentValue = 0;
            _numberEntered1 = String.Empty;
            _numberEntered2 = String.Empty;
            _operator = String.Empty;
            _answer = String.Empty;
        }

        public void AcceptCharacter(char input) // Defines AcceptCharacter, which is called by HandleInput
                                                // in each button's click event handler.
        {
            // For every input of 0-9:
            {
                if (_numberEntered1 == string.Empty) // is empty, it's the first digit entered AMY IS THIS SAFE?
                
                    _numberEntered1 = input.ToString(); // Replace the empty string with the input (digit entered).
           
                // otherwise, if there's something in NE1, append input to it.
                else
                
                    _numberEntered1 = _numberEntered1 + input.ToString();
                
                _answer = _numberEntered1;
            }

            // If input is in a set of the four operators, store it in _operator.
//            {
//                if (operators.Contains(input.ToString()))
//                {
//                    _operator = input.ToString();
//                }
//                
//            }

// Here will go assigning a value to _answer, the last step in AcceptCharacter (?)
        }

        public string GetOutput()
        {
            return _answer;
        }
    }
}


