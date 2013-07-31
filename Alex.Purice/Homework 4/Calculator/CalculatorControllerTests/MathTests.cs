using System;
using System.Linq.Expressions;
using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    class MathTests
    {
        // This CalculatorController instance will be created before any test is run, and will be used by each test in turn.
        private readonly CalculatorController _controller = new CalculatorController();

        // The method that is marked with the [SetUp] annotation is run before each test is run.
        // In this case, its purpose is to call Clear() on the CalculatorController so that each test starts with a clean slate.

        [SetUp]
        public void BeforeEachTest()
        {
            _controller.Clear();
        }

        private bool DoMath(char @operator)
        {
            decimal expectedResult = 0;
            Random random = new Random();
            decimal number1 = random.Next(0, int.MaxValue);
            decimal number2 = random.Next(0, int.MaxValue);
            switch (@operator)
            {
                case '+':
                    expectedResult = number1 + number2;
                    break;
                case '-':
                    expectedResult = number1 - number2;
                    break;
                case '*':
                    expectedResult = number1 * number2;
                    break;
                case '/':
                    expectedResult = number1 / number2;
                    break;
            }
            
            string mathExpression = string.Format("{0}{1}{2}=", number1.ToString(), @operator.ToString(), number2.ToString());

            foreach (char expressionChar in mathExpression)
            {
                _controller.AcceptCharacter(expressionChar);
            }

            return Convert.ToDecimal(_controller.GetOutput()) == expectedResult;
        }

//        private double unifyPresicion(double number)
//        {
//            const double presicionMultiplier = 100000000.0;
//            return Math.Ceiling(number*presicionMultiplier)/presicionMultiplier;
//        }


        [Test]
        public void DigitsAreAddedToTheRightOfTheCurrentValue()
        {
            // Abstract idea in English:
            // When I enter "1" and then "3" and then "7", the calculator displays "1" and then "13" and then "137".

            // Psedocode, often following the "when I/then" paradigm
            // When I: enter "1"
            // Then: the calculator should say "1"
            // When I: enter "3"
            // Then: the calculator should say "13"
            // When I: enter "7"
            // Then: the calculator should say "137"

            // Actual test code, where each line (approximately) corresponds to a line of the pseudocode
            EnterNumber(1);
            Assert.That(_controller.GetOutput(), Is.EqualTo("1"));
            EnterNumber(3);
            Assert.That(_controller.GetOutput(), Is.EqualTo("13"));
            EnterNumber(7);
            Assert.That(_controller.GetOutput(), Is.EqualTo("137"));
        }

        [Test]
        public void CanAddSmallNumbers()
        {
            EnterNumber(7);
            AcceptCharacters("+");
            EnterNumber(3);
            AcceptCharacters("=");
            
            Assert.AreEqual("10", _controller.GetOutput());
        }

        [Test]
        public void PlusDisplaysIntermediateResultsLikeEquals()
        {
            EnterNumber(10);
            AcceptCharacters("+");
            EnterNumber(3);
            AcceptCharacters("+");

            Assert.AreEqual("13", _controller.GetOutput());

            EnterNumber(15);

            Assert.AreEqual("15", _controller.GetOutput());

            AcceptCharacters("=");

            Assert.AreEqual("28", _controller.GetOutput());
        }

        [Test]
        public void CanExceedMaxInt()
        {
            EnterNumber(int.MaxValue);
            AcceptCharacters("+");
            EnterNumber(int.MaxValue);
            AcceptCharacters("=");

            long expectedResult = (long)int.MaxValue + int.MaxValue;

            Assert.AreEqual(expectedResult.ToString(), _controller.GetOutput());
        }

        [Test]
        public void CanExceedMaxLong()
        {
            EnterNumber(long.MaxValue);
            AcceptCharacters("+");
            EnterNumber(long.MaxValue);
            AcceptCharacters("=");

            Decimal expectedResult = new Decimal(long.MaxValue) + new decimal(long.MaxValue);

            Assert.AreEqual(expectedResult.ToString(), _controller.GetOutput());
        }

        // These helper functions make it easier to express simple interactions with the calculator, without having to
        // have ten or fifteen lines of "_controller.AcceptCharacter('7');" and so on
        private void EnterNumber(Decimal input)
        {
            AcceptCharacters(input.ToString());
        }

        private void AcceptCharacters(string inputString)
        {
            foreach (char expressionChar in inputString)
            {
                _controller.AcceptCharacter(expressionChar);
            }
        }

        [Test]
        public void CanAddMaxIntToMaxInt()
        {
            // Enter Int.MaxValue
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('7');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('8');
            _controller.AcceptCharacter('3');
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('7');

            // Addition
            _controller.AcceptCharacter('+');

            // Enter Int.MaxValue again
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('7');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('8');
            _controller.AcceptCharacter('3');
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('7');

            long expectedResult = (long)int.MaxValue + int.MaxValue;
            Assert.AreEqual(expectedResult.ToString(), _controller.GetOutput());
        }

        [Test]
        public void CanDoAddition()
        {
            Assert.IsTrue(DoMath('+'));
        }

        [Test]
        public void CanDoSubtraction()
        {
            Assert.IsTrue(DoMath('-'));
        }

        [Test]
        public void CanDoMultiplication()
        {
            Assert.IsTrue(DoMath('*'));
        }

        [Test]
        public void CanDoDivision()
        {
            Assert.IsTrue(DoMath('/'));
        }
    }
}
