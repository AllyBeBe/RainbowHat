using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    
    public class CalculatorController
    {


        private double? _currentValue = null;
        bool _firstChar = true;
        private char _savedOperator = 'e';  
        private double? _firstValue;
        private double? _secondValue;
        private string _displayString = "0";



        public void AcceptCharacter(char input)
        {


            if (char.IsNumber(input))
            {


                if ((input == '0' && _firstChar == true) || (_currentValue.ToString().Length > 15))
                {
                    
                    _displayString = _currentValue.ToString();
                    GetOutput();
                }
                else
                {
                    double dblInput;
                    double.TryParse(input.ToString(), out dblInput);
                    if (_currentValue == null) 
                    {
                        _currentValue = 0;
                    }
                    _currentValue = (_currentValue * 10) + dblInput;
                    _displayString = _currentValue.ToString();
                    GetOutput();

                    _firstChar = false;
                }

            }
            else  
            {


                if (_savedOperator == 'e')
                {

                    switch (input)
                    {
                        case '=':
                            GetOutput();   
                            break;
                        case 'c':
                            clearValues();
                            GetOutput();
                            break;
                        default: 
                            _savedOperator = input;
                            _firstValue = _currentValue;
                            _displayString = _currentValue.ToString();

                            GetOutput();

                            _firstChar = true; 
                            _currentValue = null;  
                            break;
                    }

                }
                else                 
                {


                    switch (input)
                    {
                        case '=':
                            if (_currentValue.HasValue)
                            {
                                _secondValue = _currentValue;
                                DoMath();
                            }
                            else
                            {
                                _secondValue = _firstValue;
                                DoMath();

                            }
                            break;
                        case 'c':
                            clearValues();
                            GetOutput();
                            break;
                        default: 

                            if (_currentValue.HasValue)
                            {
                                _secondValue = _currentValue;
                                DoMath();
                                _savedOperator = input;
                            }
                            else
                            {

                                _savedOperator = input;
                            }
                            break;

                    }

                }


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
                    result = _firstValue * _secondValue;
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

                default:
                    MessageBox.Show("How'd you get here?");
                    break;

            }
            _displayString = result.ToString();
            _firstValue = result;
            GetOutput();
        }

        void clearValues()
        {
            _currentValue = null;
            _displayString = "0";
            _firstChar = true;
            _firstValue = 0;
            _secondValue = 0;
            _savedOperator = 'e';
        }

        public string GetOutput()
        {
            if (_displayString == string.Empty)
            {
                _displayString = "0";
            }
            return _displayString;
        }
    }
}
