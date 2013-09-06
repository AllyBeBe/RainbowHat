using DirkGentlyCalculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    internal class ScientificFunctionsTests : BaseTestFixture
    {
        [Test]
        public void InverseTest()
        {
            DGCalculatorController calc1 = new DGCalculatorController();
            calc1.AcceptCharacter('2');
            Assert.That(calc1.GetOutput(), Is.EqualTo("2"));
            calc1.AcceptCharacter('i');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0.5"));
            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void XSquaredTest()
        {
            DGCalculatorController calc1 = new DGCalculatorController();
            calc1.AcceptCharacter('2');
            Assert.That(calc1.GetOutput(), Is.EqualTo("2"));
            calc1.AcceptCharacter('q');
            Assert.That(calc1.GetOutput(), Is.EqualTo("4"));
            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void SinTest()
        {
            DGCalculatorController calc1 = new DGCalculatorController();
            calc1.AcceptCharacter('6');
            Assert.That(calc1.GetOutput(), Is.EqualTo("6"));
            calc1.AcceptCharacter('s');
            Assert.That(calc1.GetOutput(), Is.EqualTo("-0.279415498198926"));
            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void CosTest()
        {
            DGCalculatorController calc1 = new DGCalculatorController();
            calc1.AcceptCharacter('6');
            Assert.That(calc1.GetOutput(), Is.EqualTo("6"));
            calc1.AcceptCharacter('o');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0.960170286650366"));
            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void TanTest()
        {
            DGCalculatorController calc1 = new DGCalculatorController();
            calc1.AcceptCharacter('6');
            Assert.That(calc1.GetOutput(), Is.EqualTo("6"));
            calc1.AcceptCharacter('t');
            Assert.That(calc1.GetOutput(), Is.EqualTo("-0.291006191384749"));
            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo("0"));
        }

    }
}