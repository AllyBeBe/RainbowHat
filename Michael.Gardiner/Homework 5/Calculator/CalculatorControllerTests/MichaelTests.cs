using System;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    [TestFixture]

    public class MichaelTests : BaseTestFixture
    {

        private readonly CalculatorController _controller = new CalculatorController();


        [SetUp]
        public void BeforeEachTest()
        {
            _controller.AcceptCharacter('c');
        }

        [Test]
        public void CanEnterSingleDigit()
        {
            EnterNumber(5);
            AssertOutput("5");
        }

        [Test]

        public void CanEnterMultipleDigits()
        {
            EnterNumber(1);
            AssertOutput("1");
            EnterNumber(8);
            AssertOutput("18");
        }

        [Test]
        public void CanEnterLargeDigits()
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
            EnterNumber(0);
            AssertOutput("1234567890");
        }

        [Test]
        public void CanClearBuffer()
        {
            EnterNumber(1);
            AssertOutput("1");
            EnterNumber(0);
            AssertOutput("10");
            AcceptCharacters("C");
            AssertOutput("0");
        }

        [Test]
        public void CanDoAddition()
        {
            EnterNumber(1);
            EnterNumber(5);
            AssertOutput("15");
            AcceptCharacters("+");
            EnterNumber(3);
            EnterNumber(0);
            AssertOutput("30");
            AcceptCharacters("=");
            AssertOutput("45");
        }

        [Test]
        public void CanDoSubtraction()
        {
            EnterNumber(2);
            EnterNumber(5);
            AssertOutput("25");
            AcceptCharacters("-");
            EnterNumber(2);
            EnterNumber(2);
            AssertOutput("22");
            AcceptCharacters("=");
            AssertOutput("3");
        }

        [Test]
        public void CanSubtractToNegtiveNumber()
        {
            EnterNumber(2);
            EnterNumber(5);
            AssertOutput("25");
            AcceptCharacters("-");
            EnterNumber(2);
            EnterNumber(8);
            AssertOutput("28");
            AcceptCharacters("=");
            AssertOutput("-3");
        }

        [Test]
        public void CanDoMultiplication()
        {
            EnterNumber(5);
            AcceptCharacters("*");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("25");
        }

        [Test]
        public void CanMultiplyByZero()
        {
            EnterNumber(9);
            AcceptCharacters("*");
            EnterNumber(0);
            AcceptCharacters("=");
            AssertOutput("0");

        }

        [Test]
        public void CanDoMultiDigitMultiplication()
        {
            EnterNumber(1);
            EnterNumber(3);
            AssertOutput("13");
            AcceptCharacters("*");
            EnterNumber(1);
            EnterNumber(5);
            AssertOutput("15");
            AcceptCharacters("=");
            AssertOutput("195");
        }

[Test]
        public void CanDevideSingleNumber()
        {
            EnterNumber(8);
            AcceptCharacters("/");
            EnterNumber(2);
            AcceptCharacters("=");
            AssertOutput("4");

        }

        [Test]
        public void CanDevideZero()
        {
            EnterNumber(0);
            AcceptCharacters("/");
            EnterNumber(3);
            AcceptCharacters("=");
            AssertOutput("0");

        }

        [Test]
        public void CannotDevideByZero()
        {
            EnterNumber(4);
            AcceptCharacters("/");
            EnterNumber(0);
            AcceptCharacters("=");
            AssertOutput("Cannot divide by zero");
        }

        [Test]
        public void CanPerformMultipleOperations()
        {
            EnterNumber(3);
            AcceptCharacters("+");
            EnterNumber(7);
            AcceptCharacters("*");
            EnterNumber(14);
            AcceptCharacters("-");
            EnterNumber(5);
            AcceptCharacters("/");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("27");
        }
    }
}
