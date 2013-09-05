using System;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    class FunctionTests : BaseTestFixture
    {
        [Test]
        public void CanTanZeroRadians()
        {
            ForInputExpect("0t", "0");
        }
        [Test]
        public void CanTanFortyFiveRadians()
        {
            ForInputExpect("45t", "1.61977519054386");
        }

        [Test]
        public void CanCosineZeroRadians()
        {
            ForInputExpect("0o", "1");
        }

        [Test]
        public void CanCosineNinetyRadians()
        {
            ForInputExpect("90o", "-0.44807361612917");
        }

        [Test]
        public void CanSineZeroRadians()
        {
            ForInputExpect("0s", "0");
        }

        [Test]
        public void CanSineNinetyRadians()
        {
            ForInputExpect("90s", "0.893996663600558");
        }

        [Test]
        public void CanSquarePositive()
        {
            ForInputExpect("3q", "9");
        }

        [Test]
        public void CanSquareNegative()
        {
            ForInputExpect("-3q", "9");
        }

        [Test]
        public void CanNegatePositive()
        {
            ForInputExpect("1#", "-1");
        }

        [Test]
        public void CanNegateNegative()
        {
            ForInputExpect("-1#", "1");
        }

        [Test]
        public void CanReciprocal()
        {
            ForInputExpect("10r", "0.1");
        }
    }
}
