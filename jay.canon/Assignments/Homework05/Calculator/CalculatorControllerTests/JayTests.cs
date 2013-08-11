using System;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
    //Homework 05 re-write for deterministic behaviorial tests on CalculatorController and using 
    //M. Phoenix's BaseTestFixture helper methods
{
    [TestFixture]
    public class JayTests : BaseTestFixture
    {
        [SetUp]
        public void ClearCalculatorBeforeEachTest()
        {
            BeforeEachTest();
        }

        [Test]
        public void CanEnterSingleDigit()
        {
            EnterNumber(1);
            AssertOutput("1");
        }

        [Test]
        public void ClearResetToZero()
        {
            EnterNumber(1);
            AssertOutput("1");
            EnterNumber(2);
            AssertOutput("12");
            AcceptCharacters("C");
            AssertOutput("0");
        }

       [Test]
        public void CanEnterMultipleDigits()
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
        public void CanDoAddition()
        {
            EnterNumber(25);
            AcceptCharacters("+");
            EnterNumber(69);
            AcceptCharacters("=");
            AssertOutput("94");
        }

        [Test]
        public void CanDoSubtraction()
        {
            EnterNumber(94);
            AcceptCharacters("-");
            EnterNumber(69);
            AcceptCharacters("=");
            AssertOutput("25");
        }

        [Test]
        public void CanDisplayNegativeIntegers()
        {
            EnterNumber(13);
            AcceptCharacters("-");
            EnterNumber(14);
            AcceptCharacters("=");
            AssertOutput("-1");
        }
        [Test]
        public void CanDoMultiplication()
        {
            EnterNumber(25);
            AcceptCharacters("*");
            EnterNumber(69);
            AcceptCharacters("=");
            AssertOutput("1725");
        }

        [Test]
        public void CanDoDivision()
        {
            EnterNumber(1725);
            AcceptCharacters("/");
            EnterNumber(69);
            AcceptCharacters("=");
            AssertOutput("25");
        }

        [Test]
        public void CanIgnoreAllButLastOperatorInput()
        {
            EnterNumber(25);
            AcceptCharacters("+");
            AcceptCharacters("*");
            EnterNumber(69);
            AcceptCharacters("=");
            AssertOutput("1725");
        }

        [Test]
        public void CanWarnDivisionByZero()
        {
            EnterNumber(1725);
            AcceptCharacters("/");
            EnterNumber(0);
            AcceptCharacters("=");
            AssertOutput("Cannot divide by zero");
        }

        [Test]
        public void CanDivideZeroByAnyNumber()
        {
            EnterNumber(0);
            AcceptCharacters("/");
            EnterNumber(1725);
            AcceptCharacters("=");
            AssertOutput("0");
        }

        [Test]
        public void CanDoUnaryOperations_Add()
        {
            EnterNumber(9);
            AcceptCharacters("+");
            AcceptCharacters("=");
            AssertOutput("18");
        }

        [Test]
        public void CanDoUnaryOperations_Subtract()
        {
            EnterNumber(9);
            AcceptCharacters("-");
            AcceptCharacters("=");
            AssertOutput("0");
        }

        [Test]
        public void CanDoUnaryOperations_Multiply()
        {
            EnterNumber(9);
            AcceptCharacters("*");
            AcceptCharacters("=");
            AssertOutput("81");
        }

        [Test]
        public void CanDoUnaryOperations_Divide()
        {
            EnterNumber(9);
            AcceptCharacters("/");
            AcceptCharacters("=");
            AssertOutput("1");
        }

        public void RepeatedClickOfEqual()
        {
            EnterNumber(1);
            AcceptCharacters("+");
            AcceptCharacters("=");
            AssertOutput("2");
            AcceptCharacters("=");
            AssertOutput("3");
            AcceptCharacters("=");
            AssertOutput("4");
            AcceptCharacters("=");
            AssertOutput("5");
        }

        [Test]
        public void CanPerformMultipleOperations()
        {
            EnterNumber(9);
            AcceptCharacters("+");
            EnterNumber(7);
            AcceptCharacters("*");
            EnterNumber(18);
            AcceptCharacters("-");
            EnterNumber(3);
            AcceptCharacters("/");
            EnterNumber(5);
            AcceptCharacters("=");
            AssertOutput("57");
        }
    }
}