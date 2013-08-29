using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
        private bool _IsFirstOperatorBeforeNumber;
        private bool _IsFirstOperatorAddedToCurrentValue;
        private static bool _IsFirstNumberEntered;
        
        private bool _IsTryingToDivideNonZeroByZero;
        private bool _IsTryingToDivideZeroByZero;


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
            _IsFirstNumberEntered = false;
            _IsFirstOperatorBeforeNumber = false;
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

                // Record the '+' operator or '-' operator or '*' operator or '/' operator
            else if (input == '+' || input == '-' || input == '*' || input == '/')
            {
                if (_currentValue == "0" && input != '+' && _IsFirstNumberEntered != true)
                {
                    _IsFirstOperatorBeforeNumber = true;
                    _operator = input;
                    return;
                }

                if (_IsFirstOperatorBeforeNumber == true && _operator == '-')
                {
                    _currentValue = _operator + _currentValue;
                }

                _operator = input;
                // save the '_currentValue' into '_previousValue'
                _previousValue = _currentValue;
                // Clear out the _currentvalue
                _currentValue = "";
                
                _IsFirstOperatorBeforeNumber = false;
                _IsFirstNumberEntered = false;
            }

            else if (input == '=')
            {
                if (_IsFirstOperatorBeforeNumber == true)
                {
                    if (_currentValue != "0")
                    {
                        if (_operator == '/' || _operator == '*')
                        {
                            _result = "0";
                            return;
                        }
                        _result = _operator + _currentValue;
                    }
                }
                else if (_operator == '+')
                {
                    _result = Convert.ToString(Convert.ToDouble(_previousValue) + (Convert.ToDouble(_currentValue)));
                }
                else if (_operator == '-')
                {
                    _result = Convert.ToString(Convert.ToDouble(_previousValue) - (Convert.ToDouble(_currentValue)));
                }
                else if (_operator == '*')
                {
                    _result = Convert.ToString(Convert.ToDouble(_previousValue)*(Convert.ToDouble(_currentValue)));
                }
                else if (_operator == '/')
                {
                    if (_currentValue == "0")
                    {
                        if (_previousValue == "0")
                        {
                            _IsTryingToDivideNonZeroByZero = false;
                            _IsTryingToDivideZeroByZero = true;

                        }
                        else
                        {
                            _IsTryingToDivideNonZeroByZero = true;
                            _IsTryingToDivideZeroByZero = false;
                        }
                    }

                    else
                    {
                    _result = Convert.ToString(Convert.ToDouble(_previousValue)/(Convert.ToDouble(_currentValue)));
                    }

                    //_result = _currentValue;
                    //_currentValue = "";

                }
            }

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
                    _IsFirstNumberEntered = true;
                }

            }

        }
        

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            // if we'r trying to Divide anything else by Zero
            // return "Cannot Divide by Zero"
            if (_IsTryingToDivideNonZeroByZero)
            {
                return "Cannot divide by zero";
            }

             // if we'r trying to Divide Zero By Zero
            // return "Result is undefined"
           if (_IsTryingToDivideZeroByZero)
            {
                return "Result is undefined";
            }
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

        //if waiting for Second Operand, display 
        // _previousValue rather than _currentValue
   // {
     //   if (_IsWaitingForSecondOperand)
     //   {
      ///      return _previousValue.ToString();
      //  }

     ///   return _currentValue.ToString();
  //  }
        
    }

}
