using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private Decimal _currentValue;
        //private string _currentStringValue;

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            // When the user enters 'c', clear out the current state.
            // When the user enters anything other than 'c',
            // add it to the right-hand side of the current state.
            
            
            // What do we do when the input is '+'?
            // Store the current value somewhere
            // Store the "Add" operation somewhere
            // Accept a new (multi-digit) value...


            // What do we do when the input is '='?
            // Do the stored operation to the stored value and the current value..


            if (input == 'c')
            {
                //_currentStringValue = String.Empty;
                _currentValue = 0;
            }
            else
            {
                //_currentStringValue = _currentStringValue + input;
                _currentValue = _currentValue*10 + int.Parse(input.ToString());
            }
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
//            if (_currentStringValue == String.Empty)
//            {
//                return "0";
//            }
//            else
//            {
//                return _currentStringValue;
//            }
            return _currentValue.ToString();
        }
    }
}
