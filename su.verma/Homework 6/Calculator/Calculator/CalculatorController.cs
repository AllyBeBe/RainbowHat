using System;
using System.Globalization;
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
        private Boolean _operatorBeforeNumber;


        public CalculatorController()

        {
            ClearCalculatorState();
        }

        private void ClearCalculatorState()
        {
            _operator = '0';
            _currentValue = "0";
            _previousValue = "";
            _result = "";
        }


        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            //Clearing out the calculator
            if (input == 'c')
            {
                ClearCalculatorState();
            }

                // Record the '+' operator
            else if (input == '+' || input  == '-')
            {
                if (_currentValue == "0")
                {
                    _operatorBeforeNumber = true;
                    _operator = input;
                    return;
                }

                _operator = input;

                    // save the '_currentValue' into '_previousValue'
                    _previousValue = _currentValue;
                    // Clear out the _currentvalue
                    _currentValue = "";
                _operatorBeforeNumber = false;


            }

            else if (input == '=')
            {
                if (_operatorBeforeNumber == true)
                {
                    _result = _operator + _currentValue;
                }
                else  if (_operator == '+')
                {
                    _result = (Convert.ToDouble(_previousValue) + Convert.ToDouble(_currentValue)).ToString();
                }

                //_result = _currentValue;
                //_currentValue = "";

            }
                //There is no _currentValue and user has typed a digit

            else if (_currentValue == "")
            {
                _currentValue = input.ToString();
                _result = "";

            }
                //There is a _currentValue and user has typed a digit
            else if (_currentValue != "")
            {

                // If _currentValue is "0", remove that "0" before adding input 
                if (_currentValue == "0")
                {
                    _currentValue = "";
                }

                //Only add the digits if we have fewer than 15 digits entered 
                if (_currentValue.Length < 15)
                {
                    _currentValue = _currentValue + input;
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

            // if they have entered a '+' but _currentValue is still "", display 
            // the previous value

            if (_operator == '+' && _currentValue == "")
            {
                return _previousValue;
            }

            return _currentValue;
        }
    }
}
