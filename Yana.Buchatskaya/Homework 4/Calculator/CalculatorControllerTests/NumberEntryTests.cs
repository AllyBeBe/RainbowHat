using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    [TestFixture]
    class NumberEntryTests
    {
        [Test]
        public void CalculatorStartsOffShowingZero()
        {
            //make a new calculator controller
            CalculatorController calc1 = new CalculatorController();

            //check that GetOutput() is equal to "o"
            Assert.That(calc1.GetOutput(), Is.EqualTo("0")); //Google "NUnit constraints"
           // or Assert.AreEqual(calc1.GetOutput(), "0");
        }

        [Test]
        public void CalculatorClearButtonResetsValueToZero()
        {
            //Make a new calculator controller
            //Enter a non-zero number
            //Convert the number
            // Click clear button
            // Assert output is equals to zero

            CalculatorController calc1 = new CalculatorController();

            calc1.AcceptCharacter('5');
            // Someday, this method will reset the calculator controller to a "like-new" state.
            // I added it to the public interface of the CalculatorController class so that tests
            // can share a CalculatorController instance -- they just need to call "Clear" before 
            // each test.

            calc1.AcceptCharacter('c');
            Assert.That(calc1.GetOutput(), Is.EqualTo('0'));
        }
    }
}
