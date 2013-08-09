using NUnit.Framework;

namespace CalculatorControllerTests
{
    class UnwrittenTests
    {

        // Tiina
        // More Tests that are not included:  
        //  These would be crucial for a production system but are of limited value as an academic exercise.
        //
        // - Computations near MinValues
        // - Checking for computations crossing through and using zero (both display and computational checks)
        // - All testing of cases beyond INT precision level
        // - All testing of decimal/floating point use
        // - Suite of tests for scientific notation support
        //
        // Nonstandard/More obscure cases


        // Tiina
        //  CanPerformMultipleOperations   15+3-8*20=
        //  CanAddLargeNumbers
        //  CanSubtractLargeNumbers
        //  CanDivideLargeNumbers
        //  CanMultiplyLargeNumbers
        //
        //
        //  Omitting use of Clear key - assumption is new number after equals is start of new computation
        //  3+4=4+5=   should yield 7 then 9

        // Tiina
        // Nonstandard cases
        //  Understands +=  -=  *= and /=  as operating on last result
        //          1+2+= 6     any number -=  0        4*= 16     any number /=  1

        // Tiina
        //  CanIgnoreExtraneousOperators  1+2+++= (6) ;   3-+4  (7)
        //   
        //  CanIgnoreAbsenceOfOperators   13=14=59 (13 then 14 then 59)   

        // Tiina
        // Boundary Conditions and overflows

        // Tiina
        [Test]
        public void CanOverflowMaxInt()
        {
            // set first value to just under max int, Add a reasonable value to it to force it over max int
            // check that the return value now is in Scientific Notation
            // 
            // Do the same for the number of display characters on output screen (8-10 chars??)
        }

        // Tiina
        [Test]
        void CanUnderflowOnDivide()
        {
            //  Divide until the number extends past the number of chars available on output screen and then
            //  make sure it is converted to Scientific Notation
        }


        // Tiina
        [Test]
        public void CanOverflowAtCorrectValue()
        {
        }

    }
}
