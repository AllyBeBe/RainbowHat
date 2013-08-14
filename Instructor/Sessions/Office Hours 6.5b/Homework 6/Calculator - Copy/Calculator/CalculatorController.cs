using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private int _currentValue;
        private int _previousValue;
        private bool OperatorAdd;
        private bool OperatorSubtract;
        private bool OperatorMultiply;
        private bool OperatorDivide;



        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.

        public void AcceptCharacter(char input)
        {
            if (input == 'c')
            {
                _currentValue = 0;
            }
            else if (input == '+')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorAdd = true;
            }
            else if (input == '-')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorSubtract = true;
            }
            else if (input == '*')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorMultiply = true;
            }
            else if (input == '/')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorDivide = true;
            }
            else
            {
                _currentValue = _currentValue*10 + int.Parse(input.ToString());
            }
        }
      

        public string GetOutput()
        {
            return _currentValue.ToString();
        }
    }
}
