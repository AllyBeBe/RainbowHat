using System;
using System.Drawing.Text;

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

        private string NumberEntered1;
        private string NumberEntered2;
        private string Operator;
        private string Answer;

        // Sections of this method:
        // Assuming user inputs only in this order: number, operator, number, equals.
        // (Later, when user can enter anything in any order, will we have to keep track of each input in order for each round until equals?)
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
        // 3. Then, go to GetOutput, which returns the value of Answer to the textbox.
        //
        // If the input is zero through 9, 
        // and NE1 is empty
        // store it in NE1.
        //
        // and NE1 isn't empty
        // append it to what's in NE1 and re-store it in NE1.
        // (Keep doing this until an operator or equals is entered.)
        //
        // If input is an operator
        // store it in Operator
        // (will that overwrite what was there, so it stores only the last operator entered?)
        //
        // After operator is entered:
        // If the input is zero through 9, Do the above for NE2
        public void AcceptCharacter(char input) // Method
        {
            // Clear the variables.
            {
                NumberEntered1 = "";
                NumberEntered2 = "";
                Operator = "";
                Answer = "";
            }

            // For every input of NE1, do this loop:
            {
                if (NumberEntered1 == ""); // is empty, it's the first digit entered
                NumberEntered1 = input.ToString();
            // otherwise, if there's something in NE1, append input to it.
                {
                    NumberEntered1 = NumberEntered1 + input.ToString();
                }
            }
            
            {
                
            }





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
            if (Answer != null) return Answer;
        }
    }
}
