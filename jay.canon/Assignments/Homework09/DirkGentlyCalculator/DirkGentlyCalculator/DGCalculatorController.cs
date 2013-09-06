using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirkGentlyCalculator
{
    public class DGCalculatorController
    {
        private string _displayReadout;         // what is displayed in output.Text
        private double _currentTotal;           // stores intermediate results from operand calculations
        private bool _isOperandEntry = false;       // indicates state of whether or not user is entering an operand
        private bool _shouldShowResults = false;    // indicates state of whether or not user user expects results from operand calculations
        private bool _errorFlag = false;            // indicates state of errors
        private bool _hasDecimal = false;           // 
        private bool _clearFlag = true;
        private char _currentOperator = '=';        /* indicates type of operation to drive switch-case decision for calculations; 
                                                       must be initialized to '=' to drive transfer of inputted to intermediate storage */
        public string DisplayResult = "";           // string holder to store double variables
        private string _errorText;                  // holds string describing errors
        private const int MaxDigitDisplay = 15; // maximum digits to display

        public void AcceptCharacter(char input)
        {
            switch (input)
            {
                case 'c':
                    Clear();
                    break;
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
                    if (_shouldShowResults)
                    {
                        Clear();
                    }
                    if (!_isOperandEntry)
                    {
                        _displayReadout = "0";
                        _isOperandEntry = true;
                    }

                    if (_digitMaxReached(input))
                    {
                        if (_clearFlag)
                        {
                            if (input != '0' && !_hasDecimal)
                            {
                                _displayReadout = string.Empty;
                                _clearFlag = false;
                                _displayReadout += input;
                            }
                            else
                            {
                                _displayReadout = "0";
                            }
                        }
                        else
                        {
                            _displayReadout += input;
                        }
                    }
                    break;
                case '.':
                    if (!_hasDecimal)
                    {
                        if (_displayReadout.Length != 0)
                        {
                            if (_displayReadout != "0")
                            {
                                _displayReadout += input;
                                _hasDecimal = true;
                            }
                            else
                            {
                                _displayReadout = "0.";
                            }
                        }
                        else
                        {
                            _displayReadout = "0.";
                        }
                    }
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    if (_isOperandEntry)
                    {
                        _Calculate();
                    }
                    _displayReadout = Convert.ToString(_currentTotal);
                    _currentOperator = input;
                    _isOperandEntry = false;
                    _shouldShowResults = false;
                    break;
                case 'i': // find inverse of operand
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case 'q': // find operand squared
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case 's': // find sin of operand
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case 'o': // find cosine of operand
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case 't': // find tangent of operand
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case 'x': // change operand's sign
                    _currentOperator = input;
                    _Calculate();
                    _isOperandEntry = false;
                    break;
                case '=':
                    _Calculate();
                    _isOperandEntry = false;
                    _shouldShowResults = true;
                    _hasDecimal = false;
                    break;
            }
        }

     
        // maximum of 15-digits per operand can be entered - modelled after WinCalc
        // sound system beep and prohibit additional digit entry
        private Boolean _digitMaxReached(double digitEntry)
        {
            if (_displayReadout.Length >= MaxDigitDisplay)
            {
                SystemSounds.Beep.Play();
                return false;
            }
            return true;
        }

        public void Clear() // reinitialize variables and flags.
        {
            _displayReadout = "0";
            _currentTotal = 0;
            _currentOperator = '=';
            _shouldShowResults = false;
            _isOperandEntry = false;
            _errorFlag = false;
            _clearFlag = true;
            _errorText = string.Empty;
            DisplayResult = "0";
        }

        private void _Calculate()
        {
            switch (_currentOperator)
            {
                case 'i':   // inverse operator
                    _currentTotal = 1/Double.Parse(_displayReadout);
                    break;
                case 'q':   // power of 2 operator
                    _currentTotal = System.Math.Pow(Double.Parse(_displayReadout), 2);
                    break;
                case 's':   // sin function
                    _currentTotal = System.Math.Sin(Double.Parse(_displayReadout));
                    break;
                case 'o':   // cosine function
                    _currentTotal = System.Math.Cos(Double.Parse(_displayReadout));
                    break;
                case 't':   // tangent function
                    _currentTotal = System.Math.Tan(Double.Parse(_displayReadout));
                    break;
                case 'x': // change operand sign toggle
                    if (_displayReadout.Length > 0)
                    {
                        _currentTotal = -1*Double.Parse(_displayReadout);
                        _displayReadout = _currentTotal.ToString();
                        _currentOperator = '=';
                    }
                    break;
                case '+':
                    _currentTotal += Double.Parse(_displayReadout);
                    break;
                case '-':
                    _currentTotal -= Double.Parse(_displayReadout);
                    break;
                case '*':
                    _currentTotal *= Double.Parse(_displayReadout);
                    break;
                case '/':
                    if (_currentTotal == 0.0 && Double.Parse(_displayReadout) == 0.0)
                    {
                        _errorFlag = true;
                        _errorText = "Result is undefined";
                        return;
                    }
                    if (Double.Parse(_displayReadout) == 0.0)
                    {
                        _errorFlag = true;
                        _errorText = "Cannot divide by zero";
                        return;
                    }
                    _currentTotal /= Double.Parse(_displayReadout);
                    break;
                case '=':
                    _currentTotal = Double.Parse(_displayReadout);
                    break;
            }
            _clearFlag = true;
            _hasDecimal = false;
        }

        public string GetOutput()
        {
            if (_errorFlag)
            {
                DisplayResult = _errorText;
            }
            else if (_isOperandEntry)
            {
                DisplayResult = _displayReadout;
            }
            else
            {
                DisplayResult = _currentTotal.ToString();
            }

            if (_currentTotal > 4)
            {
                DisplayResult = "A Suffusion of Yellow";
            }

            return DisplayResult;
        }
    }
}
