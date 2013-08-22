using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.

    // my problem is I think in static classes. 
    public class CalculatorController
    {


        private double? _currentValue = 0;
        bool _firstChar = true;
        private char _savedOperator = 'e';  //char doesn't have a null/empty value to check from what I could find.
        private double? _firstValue;
        private double? _secondValue;
        private string _displayString = "0";



        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {

            
            if (char.IsNumber(input))
            {


                if (input == '0' && _firstChar == true)
                {
                    //leading zero.
                    _displayString = "0";
                    GetOutput();
                }
                else
                {
                    if (_currentValue.ToString().Length < 15)
                    {
                    double dblInput;
                    double.TryParse(input.ToString(), out dblInput);
                    _currentValue = (_currentValue * 10) + dblInput;
                    _firstChar = false;
                    _displayString = _currentValue.ToString();
                    GetOutput();
                    }
                    else  //just return what you had before.
                    {
                        _displayString = _currentValue.ToString();
                        GetOutput();
                    }
                }

            }
            else  //not a number.
            {
                 if (_savedOperator == 'e')
                 {
                     // don't do anything if equals used without having an operator first.
                    if (input == '=')
                    {
                    _displayString = _currentValue.ToString();
                    GetOutput();
                    
                    }
                    else
                    { //if the operator is hit without entering non-zero number, this will use the zero.
                    
                    _savedOperator = input;
                    _firstValue = _currentValue;
                    _displayString = _currentValue.ToString();
                    GetOutput();
                    _firstChar = true; //leading zero prevention for 2nd value.
                    _currentValue = null;  //empty for 2nd value.
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
            double? result = 0;

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
                    if (_secondValue <= 0)
                    {
                        _displayString = "Cannot divide by zero";
                        break;
                    }
                    else
                    {
                        result = _firstValue / _secondValue;
                        break; 
                    }
                case 'c':
                    clearValues();
                    break;
                    
                default:
                    MessageBox.Show("How'd you get here?");
                    break;

            }
            _displayString = result.ToString();
            GetOutput();
        }

        void clearValues()
        {
            _currentValue = 0;
            _displayString = "0";
            _firstChar = true;
            _firstValue = 0;
            _secondValue = 0;
            _savedOperator = 'e';
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
