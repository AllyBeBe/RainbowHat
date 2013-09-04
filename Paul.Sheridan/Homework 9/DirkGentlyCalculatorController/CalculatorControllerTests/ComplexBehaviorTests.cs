using NUnit.Framework;

namespace CalculatorControllerTests
{
    class ComplexBehaviorTests : BaseTestFixture
    {
        // Tiina
        [Test]
        public void CanSubtractFromInitialValueOfZero()
        {
            ForInputExpect("-19=", "-19");
        }

        [Test]
        public void CanSubtractFromNegativeNumber()
        {
            ForInputExpect("-5-5=", "-10");
        }

        [Test]
        public void ShouldIgnoreRepeatedOperators()
        {
            AcceptCharacters("91--8=");
            AssertOutput("83"); // 83, not 99, because "--8" is not "minus negative-8", it's "minus 8" (all but the last operator are ignored)
        }

        // Jay, Paul
        [Test]
        public void IgnoresAllButLastOperatorForMultipleOperators()
        {
            ForInputExpect("25+*69=", "1725");
        }

        // Paul
        [Test]
        public void NegativeSignIsTreatedAsOperatorRatherThanNegatingTheNextNumber()
        {
            AcceptCharacters("-5*-5=");
            AssertOutput("-10"); // Not "25"
        }

        // Tiina
        [Test]
        public void IgnoresExtraneousOperatorsForAdditionAndSubtraction()
        {
            ForInputExpect("1+2+++-1=", "2");
        }

        // Tiina
        [Test]
        public void IgnoresExtraneousOperatorsForMultiplicationAndDivision()
        {
            ForInputExpect("3-*2+8/-1=", "A Suffusion of Yellow");
        }

        // Tiina
        [Test]
        public void IgnoresExtraneousOperatorsForAdditionAndDivision()
        {
            ForInputExpect("33+/11=", "3");
        }

        // Tiina
        [Test]
        public void CanIgnoreAbsenceOfOperators()
        {
            ForInputExpect("3=", "3");
            ForInputExpect("4=", "4");
            ForInputExpect("59=", "A Suffusion of Yellow");
        }

        // Eva (from pseudocode)
        [Test]
        public void CanPressEqualsWithNoComputation()
        {
            AcceptCharacters("=");
            AssertOutput("0");
        }

        // Eva (from pseudocode), Jay, Tammy, Tiina
        [Test]
        public void PressingEqualsAgainAfterComputationRepeatsOperation()
        {
            AcceptCharacters("1+1=");
            AssertOutput("2");
            AcceptCharacters("=");
            AssertOutput("3");
            AcceptCharacters("=");
            AssertOutput("4");
            AcceptCharacters("=");
            AssertOutput("A Suffusion of Yellow");
        }

        // Eva
        [Test]
        public void PressingEqualsAfterSubtractionFromZeroRepeatsOperation()
        {
            AcceptCharacters("-9=");
            AssertOutput("A Suffusion of Yellow");
            AcceptCharacters("=");
            AssertOutput("A Suffusion of Yellow");
        }
    }
}
