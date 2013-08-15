using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.

    // my problem is I think in static classes. 
    public class CalculatorController
    {
        private int? _currentValue = 0;
        bool _firstChar = true;
        private char _savedOperator = 'e';  //char doesn't have a null/empty value to check from what I could find.
        private int? _firstValue;
        private int? _secondValue;
        private string _displayString;



        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {

            if (input == '0' && _firstChar == true)
            {
                //leading zero.
                _displayString = "0";
                GetOutput();
                return;
                
            }
            
            if (char.IsNumber(input))
            {
               int intInput;
               int.TryParse(input.ToString(), out intInput);
                _currentValue = (_currentValue * 10) + intInput;
                _firstChar = false;
                _displayString = _currentValue.ToString();
                GetOutput();

            }
            else
            {
                    if (_savedOperator == 'e')
                 {
                // if you hit the = without having an operator.
                if (input == '=')
                {
                    _displayString = "0";
                    GetOutput();

                }
                else
                {
                    
                    _savedOperator = input;
                    _firstValue = _currentValue;
                    _currentValue = null;
                    _firstChar = false;
                    _displayString = _firstValue.ToString();
                    GetOutput();
                }


            }
            else
            {
                // there's a saved operator


                if (_currentValue.HasValue)
                {
                     _secondValue = _currentValue;
                }
                else 
                {
                //without a 2nd value, calc just readds the same value or changes the operator.
                    if (input == '=')
                    {
                        _secondValue = _firstValue;

                    }
                    else
                    {
                        _savedOperator = input;
                    }
                }
            }
                DoMath();
            }
            
        }

        void DoMath()
        {
            int? result = 0;

            switch (_savedOperator)
            {
                case '+':
                    result = _firstValue + _secondValue;
                    break;
                case '-':
                    result = _firstValue - _secondValue;
                    break;
                case '*':
                    result = _firstValue*_secondValue;
                    break;
                case '/':
                    result = _firstValue/_secondValue;
                    break;
                case 'c':
                    //call the clear function, and add a break.
                default:
                    MessageBox.Show("How'd you get here?");
                    break;

            }
            _displayString = result.ToString();
            GetOutput();
        }


        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            return _displayString;
        }
    }
}
