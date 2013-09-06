using System;
using Calculator;
using DirkGentlyCalculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    public class BaseTestFixture
    {
        // This CalculatorController instance will be created before any test is run, and will be used by each test in turn.
        protected readonly DGCalculatorController _Controller = new DGCalculatorController();

        // The method that is marked with the [SetUp] annotation is run before each test is run.
        // In this case, its purpose is to call Clear() on the CalculatorController so that each test starts with a clean slate.
        [SetUp]
        public void BeforeEachTest()
        {
            _Controller.AcceptCharacter('c');
        }

        // These helper functions make it easier to express simple interactions with the calculator, without having to
        // have ten or fifteen lines of "_controller.AcceptCharacter('7');" and so on
        protected void EnterNumber(Decimal input)
        {
            AcceptCharacters(input.ToString());
        }

        protected void AcceptCharacters(string inputString)
        {
            foreach (char expressionChar in inputString)
            {
                _Controller.AcceptCharacter(expressionChar);
            }
        }

        protected void AssertOutput(string expectedOutput)
        {
            Assert.That(_Controller.GetOutput(), Is.EqualTo(expectedOutput));
        }

        // This method was inspired by Tiina's method "stuffAndExpect(string StuffIt, string Expecting)"
        // from Homework 5.  Nice job, Tiina!  This makes a number of tests even shorter and more
        // readable than my helper methods.
        protected void ForInputExpect(string input, string expectedOutput)
        {
            AcceptCharacters(input);
            AssertOutput(expectedOutput);
        }
    }
}
