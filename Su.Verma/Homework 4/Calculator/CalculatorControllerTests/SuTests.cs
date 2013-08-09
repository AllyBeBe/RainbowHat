using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    [TestFixture]
    public class SuTests
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
        public void CanClearOutput()
        {
            _controller.AcceptCharacter('C');
            Assert.That(_controller.GetOutput(), Is.Empty);
        }

        [Test]
        public void CanEnterSingleDigit()
        {
            _controller.AcceptCharacter('1');
            Assert.That(_controller.GetOutput(), Is.EqualTo("1"));
        }

        [Test]
        public void CanEnterMultipleDigits()
        {
            _controller.AcceptCharacter('1');
            Assert.That(_controller.GetOutput(), Is.EqualTo("13"));
        }

        [Test]
        public void CanAddTwoNumbers()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('5');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("6"));
        }

        [Test]
        public void CanSubstractTwoNumbers()
        {
            _controller.AcceptCharacter('5');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("4"));
        }

        [Test]

        public void CanMultiplyTwoNumbers()
        {
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('*');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("8"));
        }

        [Test]

        public void CanDivideTwoNumbers()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('0');
            _controller.AcceptCharacter('/');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("5"));
        }

        [Test]

        public void CanAddTwoNegativeNumbers()
        {
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-2"));

        }

        [Test]

        public void CanAddOnePositivetoOneNegativeNumber()
        {
            _controller.AcceptCharacter('5');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("3"));

        }

        [Test]

        public void CanDivideOnePositiveNumberWithOneNegativeNumber()
        {
            _controller.AcceptCharacter('8');
            _controller.AcceptCharacter('/');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-4"));
        }

        [Test]

        public void CanSubstractTwoNegativeNumbers()
        {
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('3');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-5"));

        }

        [Test]

        public void CanMultiplyTwoNegativeNumbers()
        {
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('3');
            _controller.AcceptCharacter('*');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('5');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("15"));
        }

        [Test]

        public void CanDivideyByNegativeNumber()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('0');
            _controller.AcceptCharacter('/');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-5"));
        }

        [Test]

        public void CanMultiplyByNegativeNumber()
        {
            _controller.AcceptCharacter('3');
            _controller.AcceptCharacter('*');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('=');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-18"));

        }



    }
}






