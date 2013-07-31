using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    [TestFixture]
    public class SimpleNumberEntryTest
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
        public void CanEnterSingleDigit()
        {
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("1"));
        }

        [Test]
        public void CanEnterMultipleDigits()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('3');

            // An example of a constraint other than "Is"  In this case, the Substring() method of the
            // "Contains" class returns a constraint that requires that the value being tested contain the
            // substring "3".
            Assert.That(_controller.GetOutput(), Contains.Substring("3"));

            Assert.That(_controller.GetOutput(), Is.EqualTo("13"));
        }

        [Test]
        public void DoesClearWork()
        {
            _controller.AcceptCharacter('1');
            _controller.Clear();

            Assert.That(_controller.GetOutput(),Is.EqualTo(""));
        }


        [Test]
        public void DoesSingleDigitAdditionWork()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('8');

            Assert.That(_controller.GetOutput(), Is.EqualTo("9"));
        }

        [Test]
        public void DoesMultipleDigitAdditionWork()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('9');

            Assert.That(_controller.GetOutput(), Is.EqualTo("110"));
        }

        [Test]
        public void DoesStartingZeroAdditionWork()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('0');

            Assert.That(_controller.GetOutput(), Is.EqualTo("11"));
        }

        [Test]
        public void DoesEndingZeroAdditionWork()
        {
            _controller.AcceptCharacter('0');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('0');

            Assert.That(_controller.GetOutput(), Is.EqualTo("10"));
        }

        [Test]
        public void DoesMultipleDigitSubtractionWork()
        {
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('0');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('9');

            Assert.That(_controller.GetOutput(), Is.EqualTo("82"));
        }

        [Test]
        public void DoesSingleDigitSubtractionWork()
        {
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('6');

            Assert.That(_controller.GetOutput(), Is.EqualTo("3"));
        }

        [Test]
        public void DoesFirstZeroDigitSubtractionWork()
        {
            _controller.AcceptCharacter('0');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('9');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-19"));
        }

        [Test]
        public void DoesLastZeroDigitSubtractionWork()
        {
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('0');

            Assert.That(_controller.GetOutput(), Is.EqualTo("91"));
        }


        [Test]
        public void DoesNegativeFirstDigitSubtractionWork()
        {
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('8');

            Assert.That(_controller.GetOutput(), Is.EqualTo("-17"));
        }

        [Test]
        public void DoesNegativeLastDigitSubtractionWork()
        {
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('8');

            Assert.That(_controller.GetOutput(), Is.EqualTo("99"));
        }


        [Test]
        public void DoesNegativeLastDigitAdditionWork()
        {
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('8');

            Assert.That(_controller.GetOutput(), Is.EqualTo("83"));
        }

        [Test]
        public void DoesNegativeFirstDigitAdditionWork()
        {
            _controller.AcceptCharacter('-');
            _controller.AcceptCharacter('9');
            _controller.AcceptCharacter('+');
            _controller.AcceptCharacter('1');
            _controller.AcceptCharacter('8');

            Assert.That(_controller.GetOutput(), Is.EqualTo("9"));
        }


        

    }
}
