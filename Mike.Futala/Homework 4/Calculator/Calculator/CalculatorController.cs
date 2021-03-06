﻿using System.Runtime.InteropServices;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public string AcceptCharacter(char input)
        {
            // Your code will eventually go here, to make all of the tests pass.

            // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!

            return GetOutput(input);
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput(char input)
        {
            
            return input;
        }

        public void Clear()
        {
            // Someday, this method will reset the calculator controller to a "like-new" state.
            // I added it to the public interface of the CalculatorController class so that tests
            // can share a CalculatorController instance -- they just need to call "Clear" before 
            // each test.
          

        }

      

    }
}
