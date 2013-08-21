using System;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController // Class (contains methods -- anything else?)
    {

        // Mickey notes
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        //
        // AEH: Is CalculatorController an object?  A class? Both?
        // AEH: This is a method we need to create.  What should it do?  Where does it fit in the process of 
        // Click > show string in textbox > store numbers and operators > combine them and calculate > 
        // get answer(separate step?) > show answer in textbox?

        public void AcceptCharacter(char input) // Method
        {



        }

        // Mickey notes
        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.

        // AEH: This looks to be the second to last step?  Check to see what this method's variables/parameters are. 
        // AEH: Should the code to show the Output in the textbox go here?  Or does this method's return show it in the textbox?
        //  (looks like it does, because when I run the program, the textbox shows 13)
        // AEH: Get output from where?  Before it's returned, do we need to store it?

        public string GetOutput() // Method
        {
            return "13";
        }
    }
}
