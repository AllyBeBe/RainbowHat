using System.Windows.Forms;

namespace Calculator
{
   
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private string _currentString = "0";    //what is displayed in output.Text on the Form control
        private string _operand1;               //string value to hold left operand
        private string _operand2;               //string value to hold right operand
        private bool _clearFlag = true;         //allows current operand to be displayed until operator is inputted - then flag and _currentString is cleared to make room for operand2 entry
        private char _lastOperator;             //indicates last operator entered
        private double _opr1, _opr2;           //values to hold converted operand string values

        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.
        public void AcceptCharacter(char input)
        {
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
                    if (_clearFlag == true) //clear any existing operations and reset calculator to display 'zero'
                    {
                        if (input != '0')   //eliminate any leading zeros
                        {
                            _currentString = string.Empty;
                            _clearFlag = false;
                            _currentString += input;
                        }
                        else
                            _currentString = "0";
                    }
                    else
                    {
                        _currentString += input;
                    }
                    break;
                case 'c':   //user initiated clear 
                    _currentString = "0";
                    _clearFlag = true;
                    break;
                case '+':
                    _operand1 = _currentString;
                    _lastOperator = '+';
                    _clearFlag = true;
                    break;
                case '-':
                    _operand1 = _currentString;
                    _lastOperator = '-';
                    _clearFlag = true;
                    break;
                case '*':
                    _operand1 = _currentString;
                    _lastOperator = '*';
                    _clearFlag = true;
                    break;
                case '/':
                    _operand1 = _currentString;
                    _lastOperator = '/';
                    _clearFlag = true;
                    break;
                case '=':
                    _operand2 = _currentString;
                    double.TryParse(_operand1, out _opr1);
                    double.TryParse(_operand2, out _opr2);
                    
                    switch (_lastOperator)
                    {
                        case '+':
                            _currentString = (_opr1 + _opr2).ToString();
                            break;
                        case '-':
                            _currentString = (_opr1 - _opr2).ToString();
                            break;
                        case '*':
                            _currentString = (_opr1 * _opr2).ToString();
                            break;
                        case '/':
                            _currentString = _operand2 == "0" ? "Cannot divide by zero" : (_opr1/_opr2).ToString();
                            break;
                    }
                    break;
                default:
                    _currentString = _currentString + input;
                    break;
            }
        }

        public string GetOutput()
        {
            if (_currentString == string.Empty)
            {
                return "";
            }
            else
            {
                return _currentString;
            }
        }
    }
}
