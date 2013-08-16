using System;
using System.Collections;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private int _currentValue;
        private int _previousvalue;
        private int _finalvalue;

        private string _currentvaluestring;
        private string _previousvaluestring;
        private string _finalvaluestring;
        private string _operatorvaluestring;
        private string _mostrecentinputstring;

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
            // Your code will eventually go here, to make all of the tests pass.

            // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!
            _finalvaluestring = "";
            switch (input)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    if (_previousvaluestring == "" && _operatorvaluestring=="")
                    {
                        _currentvaluestring = Convert.ToString(input);
                        _currentValue = Convert.ToInt32(_currentvaluestring);
                        _finalvaluestring = _currentvaluestring;
                    }
                    else if (_previousvaluestring=="" && _operatorvaluestring!="")
                        _currentvaluestring = _currentvaluestring += input;
                        _currentValue = Convert.ToInt32(_currentvaluestring);
                        _finalvaluestring = _currentvaluestring;
                    break;
                case '+':
                    _previousvaluestring = _currentvaluestring;
                    _previousvalue = _currentValue;
                    _operatorvaluestring = Convert.ToString(input);
                    ClearOuput();
                    break;
                case '-':
                    _previousvaluestring = _currentvaluestring;
                    _previousvalue = _currentValue;
                    _operatorvaluestring = Convert.ToString(input);
                    ClearOuput();
                    break;
                case '/':
                    _previousvaluestring = _currentvaluestring;
                    _previousvalue = _currentValue;
                    _operatorvaluestring = Convert.ToString(input);
                    ClearOuput();
                    break;
                case '*':
                    _previousvaluestring = _currentvaluestring;
                    _previousvalue = _currentValue;
                    _operatorvaluestring = Convert.ToString(input);
                    ClearOuput();
                    break;
            }
        }

        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
        {
            //return "13";
      


            return _finalvaluestring;
        }

        public void ClearOuput()
        {
            if (_operatorvaluestring != "")
            {
                _finalvaluestring ="";   
            }
            
        }

       }
}
