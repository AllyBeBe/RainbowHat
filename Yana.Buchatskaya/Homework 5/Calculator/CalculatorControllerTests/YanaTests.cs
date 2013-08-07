using NUnit.Framework;
using Calculator;
using NUnit.Framework.Constraints;

namespace CalculatorControllerTests
{
    [TestFixture]
    public class YanaTests
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

        [Test]
        public void InitialStateIsZero()
        {
            Assert.That(_controller.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void CanEnterSingleDigit()
        {
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("1"));
        }

        [Test]
        public void CanEnterMultipleDigits()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('5');

            // An example of a constraint other than "Is"  In this case, the Substring() method of the
            // "Contains" class returns a constraint that requires that the value being tested contain the
            // substring "3".
            Assert.That(_controller.GetOutput(), Contains.Substring("3"));

            Assert.That(_controller.GetOutput(), Is.EqualTo("15"));
        }

        [Test]
        public void CanEnterEachDigit()
        {
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("1"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("12"));
            Assert.That(_controller.AcceptCharacter('3'), Is.EqualTo("123"));
            Assert.That(_controller.AcceptCharacter('4'), Is.EqualTo("1234"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("12345"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("123456"));
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("1234567"));
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("12345678"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("123456789"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("1234567890"));
            Assert.That(_controller.AcceptCharacter('C'), Is.EqualTo("0"));
        }

        [Test]
        public void CanClearCurrentDisplay()
        {
            _controller.AcceptCharacter('5');
            _controller.Clear();

            Assert.That(_controller.GetOutput(), Is.Empty);
        }

        [Test]
        public void CanIgnoreLeadingZeros()
        {
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("7")); 
        }

        [Test]
        public void CanDoBasicAdd()
        {
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("9"));
        }

        [Test]
        public void CanDoMultipleDigitAdd()
        {
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("28"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("28"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("91"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("119"));
        }


        [Test]
        public void CanDoBasicSubtract()
        {
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("3"));
        }

        [Test]
        public void CanDoUnarySubtract()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-9"));
        }

        [Test]
        public void CanDoNegativeOnSubtract()
        {
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-2"));
        }


        [Test]
        public void CanAddTwoNegativeNumbers()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("6"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("-6"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("-6"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-11"));
        }

        [Test]
        public void CanAddOneNegativeAndAnotherPositiveNumber()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("6"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("-6"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-1"));
        }

        [Test]
        public void CanSubtractTwoNegativeNumbers()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("6"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("-6"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("-6"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-15"));
        }

        [Test]
        public void CanDoBasicMultiply()
        {
            Assert.That(_controller.AcceptCharacter('4'), Is.EqualTo("4"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("4"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("20"));
        }

        [Test]
        public void CanHandleUnaryMultiply()
        {
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("0"));
        }

        [Test]
        public void CanMultiplyNegative()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("-9"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-45"));
        }

        [Test]
        public void CanDoBasicDivide()
        {
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("4"));
        }

        [Test]
        public void CanHandleUnaryDivide()
        {
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("0"));
        }

        [Test]
        public void CanNotDivideByZero()
        {
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("Cannot divide by zero"));
        }

        [Test]
        public void CanMultiplyByZero()
        {
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("0"));
        }

        [Test]
        public void SubstractionBeforeMultiplication()
        {
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-4"));
        }

        [Test]
        public void SubstractionBeforeDivision()
        {
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('4'), Is.EqualTo("4"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("1"));
        }
        


       
    }
}
