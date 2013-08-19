using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
      
        private char _operator;

        private string _currentValue;
        private string _previousValue;
        private string _result;
        

        public CalculatorController()

        {
            _operator = '0';
            _currentValue = "";
            _previousValue = "";
            _result = "";
        }


        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            if (input == 'c')
            {
                _currentValue = "";
            }

            else if (_currentValue == "")
            {
                _currentValue = input.ToString();
                _result = "";

            }

            else if (input == '+')
            {
                _operator = input;
            }

            else if (_currentValue != "" && input != '=')
            {
                _previousValue = _currentValue;
                _currentValue = input.ToString();
            }

            else if (input == '=')
            {
                if (_operator == '+')
                {
                    _result = (Convert.ToInt16(_previousValue) + Convert.ToInt16(_currentValue)).ToString();
                }
            }

            //else
            //{

            //    _currentStringValue = _currentStringValue + input;
            //}

            // Your code will eventually go here, to make all of the tests pass.

            // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            if (_result != "")
            {
                return _result;
            }
            return _currentValue;
        }
    }
}
