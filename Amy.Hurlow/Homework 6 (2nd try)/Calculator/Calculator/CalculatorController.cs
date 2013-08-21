using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {

        // Amy thinking notes
        // Take currentvalue and store it 
        // So create a new variable and assign _currentValue's value to it
        // then, take input from the next button and store that.  Do I need to clear it first?
        // I need variables in which to store each digit and operator entered, so I can combine them at "=".
        // But I don't know how many digits or operators the user will enter.
        // I can clear the variables and re-use them on the next go-round when the next button 
        // is clicked after the user clicks "=" and I show the answer.
        // 
        // Mickey notes
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        // Store the value from the last button clicked in a new variable.  I chose type long.

        public void AcceptCharacter(char input)
        {



        }

        // Mickey notes
        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            return "13";
        }
    }
}
