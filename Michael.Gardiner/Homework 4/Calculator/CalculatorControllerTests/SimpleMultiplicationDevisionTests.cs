using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    internal class SimpleMultiplicationDevisionTests
    {
        private readonly CalculatorController _controller = new CalculatorController();

        [SetUp]
        public void BeforeEachTest()
        {
            _controller.Clear();
        }

        [Test]
        public void CanPerformSimpleMultiplication()
        {
            _controller.AcceptCharacter('5');
            _controller.AcceptCharacter('*');
            _controller.AcceptCharacter('6');

            Assert.That(_controller.GetOutput(), Is.EqualTo("30"));
        }

        [Test]
        public void CanPerformSimpleDivision()
        {
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('/');
            _controller.AcceptCharacter('3');

            Assert.That(_controller.GetOutput(), Is.EqualTo("8"));
        }

        [Test]
        public void CanPerformMutilpeDigitMultiplication()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('x');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("192"));
        }

        [Test]
        public void CanPerformMutipleDigitDivision()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('/');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("12"));
        }
    }
}