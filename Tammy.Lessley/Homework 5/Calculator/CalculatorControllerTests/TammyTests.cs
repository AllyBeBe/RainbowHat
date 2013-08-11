using System.Globalization;
using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    [TestFixture]
    public class TammyTests : BaseTestFixture
    {
        // This CalculatorController instance will be created before any test is run, and will be used by each test in turn...
        private readonly CalculatorController _controller = new CalculatorController();

        // The method that is marked with the [SetUp] annotation is run before each test is run.
        // In this case, its purpose is to call Clear() on the CalculatorController so that each test starts with a clean slate.
        [SetUp]
        //public void BeforeEachTest()
        //{
        //    _controller.AcceptCharacter('c');
        //}

        [Test]
        public void CanEnterSingleDigit()
        {
            for (int a = 0; a <= 9; a++)
            {
                _controller.AcceptCharacter((char) a);
                Assert.That(_controller.GetOutput(), Is.EqualTo(a.ToString(CultureInfo.InvariantCulture)));
            }

        }

        [Test]
        public void CanEnterMultipleDigits()
        {
            EnterNumber(1);
            EnterNumber(3);
            AssertOutput("13");
            // An example of a constraint other than "Is"  In this case, the Substring() method of the
            // "Contains" class returns a constraint that requires that the value being tested contain the
            // substring "3".
            //Assert.That(_controller.GetOutput(), Contains.Substring("3"));

            
        }

        [Test]
        public void CanEnterUpTo16Digits()
        {
            EnterNumber(1);
            AssertOutput("1");
            EnterNumber(2);
            AssertOutput("12");
            EnterNumber(3);
            AssertOutput("123");
            EnterNumber(4);
            AssertOutput("1234");
            EnterNumber(5);
            AssertOutput("12345");
            EnterNumber(6);
            AssertOutput("123456");
            EnterNumber(7);
            AssertOutput("1234567");
            EnterNumber(8);
            AssertOutput("12345678");
            EnterNumber(9);
            AssertOutput("123456789");
            EnterNumber(1);
            AssertOutput("1234567891");
            EnterNumber(2);
            AssertOutput("12345678912");
            EnterNumber(3);
            AssertOutput("123456789123");
            EnterNumber(4);
            AssertOutput("1234567891234");
            EnterNumber(5);
            AssertOutput("12345678912345");
            EnterNumber(6);
            AssertOutput("123456789123456");
            EnterNumber(7);
            AssertOutput("1234567891234567");
            EnterNumber(8);
            AssertOutput("1234567891234567");
        }

        [Test]
        public void ClearNumbersDisplayed()
        {
            EnterNumber(6);
            EnterNumber(2);
            AcceptCharacters("c");

            Assert.That(_controller.GetOutput(), Is.Empty);
        }

        [Test]
        public void EnterMultipleZeros()
        {
            EnterNumber(0);
            EnterNumber(0);
            EnterNumber(0);
            AssertOutput("0");
        }

        [Test]
        public void SubtractNegativeNumbers()
        {
            AcceptCharacters("-");
            EnterNumber(5);
            AcceptCharacters("-");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("-10");
        }

        [Test]
        public void SingleDigitAddition()
        {
            EnterNumber(2);
            AcceptCharacters("+");
            EnterNumber(8);
            AssertOutput("10");

        }

        [Test]
        public void MultipleNumberAddition()
        {
            EnterNumber(2);
            EnterNumber(3);
            AssertOutput("23");
            AcceptCharacters("+");
            EnterNumber(9);
            AcceptCharacters("+");
            AssertOutput("32");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("37");

        }

        [Test]
        public void SingleDigitSubtraction()
        {
            EnterNumber(2);
            AcceptCharacters("-");
            EnterNumber(8);
            AssertOutput("-6");

        }

        [Test]
        public void MultipleNumberSubtraction()
        {
            EnterNumber(2);
            EnterNumber(3);
            AssertOutput("23");
            AcceptCharacters("-");
            EnterNumber(9);
            AcceptCharacters("-");
            AssertOutput("14");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("9");

        }

        [Test]
        public void SingleNumberAdditionAndSubtraction()
        {
            EnterNumber(2);
            EnterNumber(3);
            AssertOutput("23");
            AcceptCharacters("+");
            EnterNumber(9);
            AcceptCharacters("-");
            AssertOutput("32");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("27");

        }

        [Test]
        public void SingleNumberDivision()
        {
            EnterNumber(6);
            AcceptCharacters("/");
            EnterNumber(2);
            AcceptCharacters("=");
            AssertOutput("3");

        }

        [Test]
        public void DivisionOfZero()
        {
            EnterNumber(0);
            AcceptCharacters("/");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("0");

        }

        [Test]
        public void DivisionByZero()
        {
            EnterNumber(5);
            AcceptCharacters("/");
            EnterNumber(0);
            AcceptCharacters("=");
            AssertOutput("Cannot divide by zero");

        }

        [Test]
        public void MultipleNumberDivision()
        {
            EnterNumber(9);
            AcceptCharacters("/");
            EnterNumber(1);
            AcceptCharacters("/");
            AssertOutput("9");
            EnterNumber(3);
            AcceptCharacters("=");
            AssertOutput("3");

        }

        [Test]
        public void VeryLargeNumberDivision()
        {
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            AcceptCharacters("/");
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            AcceptCharacters("=");
            AssertOutput("1");

        }

        [Test]
        public void SingleNumberMultiplication()
        {
            EnterNumber(3);
            AcceptCharacters("*");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("15");

        }

        [Test]
        public void MultiplicationOfZero()
        {
            EnterNumber(3);
            AcceptCharacters("*");
            EnterNumber(0);
            AcceptCharacters("=");
            AssertOutput("0");

        }

        [Test]
        public void MultipleNumberMultiplication()
        {
            EnterNumber(3);
            AcceptCharacters("*");
            EnterNumber(1);
            AcceptCharacters("*");
            AssertOutput("3");
            EnterNumber(2);
            EnterNumber(2);
            AcceptCharacters("=");
            AssertOutput("66");

        }

        [Test]
        public void VeryLargeNumberMultiplication()
        {
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            AcceptCharacters("*");
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            EnterNumber(9);
            AcceptCharacters("=");
            AssertOutput("9.999999999999998e+31");

        }
        [Test]
        public void LeadingZerosDoNotShow()
        {
            EnterNumber(0);
            EnterNumber(9);
            AssertOutput("9");
        }

        [Test]
        public void RepeatedClicksOnEqual()
        {
            EnterNumber(9);
            AcceptCharacters("+");
            EnterNumber(1);
            AcceptCharacters("=");
            AssertOutput("10");
            AcceptCharacters("=");
            AssertOutput("11");
            AcceptCharacters("=");
            AssertOutput("12"); 
        }
    }
}
