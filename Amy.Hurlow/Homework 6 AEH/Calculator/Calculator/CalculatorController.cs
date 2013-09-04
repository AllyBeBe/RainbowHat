﻿using System;
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
        private string _operator; // the last operator entered (should ignore any operators entered immediately before)
        private string _answer; // The result of doing the math on "equals"
        private string _display;

        private bool _digitsEnteredShouldGoIntoFirstNumber; // True if we're entering the first number, false if we're entering the second.

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

        // A contructor is a method whose name is the same as the name of the class.
        // A constructor has no return type (not even "void").
        // A conbstructor does not return a value -- its value is simply the new instance of the class
        // that is being constructed.
        // A constructor is the method that is called when you say "new SomeClassName()"
        // A constructor is called only when an instance of the class is created (constructed).
        // C# creates a "default contstructor" with no arguments, if you haven't defined any constructors.
        // This is why you can say "new CalculatorController()" even if you haven't written an 
        // explicit constructor method for CalculatorController.
        // If you want to do something once and only once in the lifetime of a CalculatorController, when you
        // first create it, you can define an explicit constructor method and do that something in that method.

        public CalculatorController()
        {
            Clear();
        }

        // Defines a method to clear the variables. 
        // Called before each test. Where else do I need it?
        public void Clear()
        {
            _digitsEnteredShouldGoIntoFirstNumber = true;
            _firstNumberEntered = "0";
            _secondNumberEntered = String.Empty;
            _operator = String.Empty;
            _display = "0";
            _answer = String.Empty;
        }

        public void AcceptCharacter(char inputChar) // Defines AcceptCharacter, which is called by HandleInput
            // in each button's click event handler.
            // For Mickey: couldn't I make AcceptCharacter's type string, since all my variables are strings?
            //
            // A: You could, except that the type of AcceptCharacter's parameter (note: you said "AcceptCharacter's
            // type", but the technically correct phrase would be "the type of AcceptCharacter's parameter") is part
            // of CalculatorController's external interface, which everything that calls it relies on.  If you were
            // to change that, you would need to also change Form1.cs and all of the tests that call AcceptCharacter.
            //
            // That's why, instead, I just renamed it to "inputChar", and introduced the local variable "input" to hold
            // the string version of the value.  Note: the *name* of AcceptCharacter's parameter is *not* part of the
            // external interface of CalculatorController, so you can change it freely."
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
                else
                {
                    _secondNumberEntered = AppendDigit(_secondNumberEntered, input);
                    _display = _secondNumberEntered;                    
                }
            }
            else if (Operators.Contains(input))
            {
                _operator = input;
                _digitsEnteredShouldGoIntoFirstNumber = false;
            }
            else if (input == "=")
            {
                if (_operator == "+")
                {
                    _answer = (double.Parse(_firstNumberEntered) + double.Parse(_secondNumberEntered)).ToString();
                }
                else if (_operator == "-")
                {
                    _answer = (double.Parse(_firstNumberEntered) - double.Parse(_secondNumberEntered)).ToString();
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
