using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    public class SimpleAdditionSubtractionTests
    {
        private readonly CalculatorController _controller = new CalculatorController();

        [SetUp]
        public void BeforeEachTest()
        {
            _controller.Clear();
        }

        [Test]
        public void CanPerformSimpleAddition()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('1');

            Assert.That(_controller.GetOutput(), Is.EqualTo("2"));
        }

        [Test]
        public void CanPerformSimpleSubtraction()
        {
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("4"));
        }

        [Test]
        public void CanPerformMutilpeDigitAddition()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('6');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('4');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("58"));
        }

        [Test]
        public void CanPerformMutipleDigitSubtraction()
        {
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('2');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('2');

            Assert.That(_controller.GetOutput(), Is.EqualTo("10"));
        }
    }
}
