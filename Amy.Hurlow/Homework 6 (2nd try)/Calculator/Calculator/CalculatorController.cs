using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private int _currentValue;
        // this is what the user just entered (by clicking)
        // Take currentvalue and store it 
        // So create a new variable and assign _currentValue's value to it
        // then, take input from the next button and store that.  Do I need to clear it first?
        private long _previousValue1;
        private String Operator;

        //
        // This is the first test I'm trying to make pass.
        // I'm having a very hard time understanding the structure of the code I'll need to write.
        // I immediately started drawing boxes on paper, but got lost trying to relate display behavior 
        // and math operators.
        // 
        // I need some way to visualize the variables and methods I'll need, and their relation to each other.
        // Unfortunately, I Googled "how to (plan/design) software" and  
        // my search led me to discover oh so many systems for modelling, each of which
        // would take time to learn.  The diagrams and structures did not seem intuitive, and seemed to require
        // actually understanding software architecture.
        // 
        // So I'll think aloud here, and see if I can come up with ways to make this one test work,
        // without trying to think about the rest of the program.
        // 
        // I need variables in which to store each digit and operator entered, so I can combine them at "=".
        // But I don't know how many digits or operators the user will enter.
        // I can clear the variables and re-use them on the next go-round when the next button 
        // is clicked after the user clicks "=" and I show the answer.
        // 
        
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        //
        // Store the value from the last button clicked in a new variable.  I chose type long.
        public void AcceptCharacter(char input)
        {
            _previousValue1 = _currentValue;
        // Now, I can't keep doing this, adding new variables for every button clicked and naming them serially.
        // because I'd have potentially a whole lot of vaiables, 
        // and all I want to do is combine them in order of entry, sort the numbers from the operators,
        // turn consecutive numbers into multi-digit numbers, and perform the operations on the numbers.
 


        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            return "13";
        }
    }
}
