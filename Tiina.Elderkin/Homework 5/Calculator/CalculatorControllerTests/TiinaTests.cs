using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    [TestFixture]
    public class TiinaTests
    {
        // This CalculatorController instance will be created before any test is run, and will be used by each test in turn.
        private readonly CalculatorController _controller = new CalculatorController();

        private void stuffAndExpect(string StuffIt, string Expecting)
        {
            foreach (char buttonpress in StuffIt )
            {
                _controller.AcceptCharacter(buttonpress);
            }
            Assert.That(_controller.GetOutput(),Is.EqualTo(Expecting));
        }

        // The method that is marked with the [SetUp] annotation is run before each test is run.
        // In this case, its purpose is to call Clear() on the CalculatorController so that each test starts with a clean slate.
        [SetUp]
        public void BeforeEachTest()
        {
            _controller.AcceptCharacter('c');
        }

        [Test]
        public void InitialStateIsZero()
        {
            Assert.That(_controller.GetOutput(), Is.EqualTo("0"));
        }

        [Test]
        public void CanEnterSingleDigit()
        {
            stuffAndExpect("1", "1"); 
        }


        [Test]
        public void CanEnterMultipleDigits()
        {
            stuffAndExpect("13", "13"); 
        }


        [Test]
        public void CanEnterEachDigit()
            // tests if the controller can build substantial multidigit numbers and that each digit is mapped correctly
        {
            stuffAndExpect("1", "1");
            stuffAndExpect("2", "12");
            stuffAndExpect("3", "123");
            stuffAndExpect("4", "1234");
            stuffAndExpect("5", "12345");
            stuffAndExpect("6", "123456");
            stuffAndExpect("7", "1234567");
            stuffAndExpect("8", "12345678");
            stuffAndExpect("9", "123456789");
            stuffAndExpect("0", "1234567890");

        }

        [Test ]
        public void CanUseResetButton()
        {
            stuffAndExpect("c","0");  // don't have a good way of testing if anything internally TRULY cleared out.
        }

        [Test]
        public void CanIgnoreLeadingZeros()
        {
            stuffAndExpect("0","0"); // should see initial zero
            stuffAndExpect("2","2"); // rather than "02"
        }

        [Test]
        public void CanDoBasicAdd()
        {
            stuffAndExpect("2+6=", "8");
        }

        [Test]
        public void BasicAddDisplaysCorrectly()
        {
            stuffAndExpect("3","3");
            stuffAndExpect("+", "3");
            stuffAndExpect("7","7");
            stuffAndExpect("=", "10");
        }

        [Test]
        public void CanDoMultipleDigitAdd()
        {
            stuffAndExpect("249+14367=", "14616");
        }

        [Test]
        public void MultipleDigitAddDisplaysCorrectly()
        {
            stuffAndExpect("28","28");
            stuffAndExpect("+","28");
            stuffAndExpect("91","91");
            stuffAndExpect("=","119");
        }


        [Test]
        public void CanDoBasicSubtract()
        {
            stuffAndExpect("6-2=", "4");
        }

        [Test]
        public void BasicSubtractDisplaysCorrectly()
        {
            stuffAndExpect("7","7");
            stuffAndExpect("-","7");
            stuffAndExpect("1","1");
            stuffAndExpect("=","6");
        }

        [Test]
        public void CanDoAndDisplayUnarySubtract()
        {
            stuffAndExpect("-","0");
            stuffAndExpect("3","3");
            stuffAndExpect("=","-3");
        }
               
        [Test]
        public void CanGoNegativeOnSubtract()
        {
            stuffAndExpect("7-9=","-2");
        }

        [Test]
        public void CanDoBasicMultiply()
        {
            stuffAndExpect("4*5=","20");
        }

        [Test]
        public void CanHandleUnaryMultiply()
        {
            stuffAndExpect("*9=","0");  // implied zero: 0*9=0
        }

        [Test]
        public void CanMultiplyNegative()
        {
            stuffAndExpect("-7*3=", "-21");
        }

        [Test]
        public void MultiplyNegativeDisplaysCorrectly()
        {
            stuffAndExpect("-9","9"); // should not show negative sign yet
            stuffAndExpect("*","-9"); // now the negative portion is applied
            stuffAndExpect("5=","-45");
        }

        [Test]
        public void CanDoBasicDivide()
        {
            stuffAndExpect("8/2=","4");
        }

        [Test]
        public void CanHandleUnaryDivide()
        {
            stuffAndExpect("/9=","0"); // this should not be an error since zero is implied:  0/9=0
        }

        [Test]
        public void CatchDivideByZero()
        {
            stuffAndExpect("8/0=","Divide by Zero"); // or whatever the programmer decided to display for a message
        }

        [Test]
        public void CanDivideByNumberWithLeadingZero()
        {
            stuffAndExpect("8/01=","8");  // the zero should be ignored and not make the calculation fail
        }

        [Test]
        public void CanPerformMultipleOperations()
        {
            stuffAndExpect("15+3-8*20=","200");
        }

        [Test]
        public void CanEnterValueNearMaxInt()
        {
            stuffAndExpect((int.MaxValue-10).ToString() + "=", (int.MaxValue-10).ToString( ));
        }

        [Test]
        public void CanAddNearMaxInt()
        {
            stuffAndExpect((int.MaxValue - 10).ToString() + "+9=", (int.MaxValue - 1).ToString());
        }

        [Test]
        public void CanSubtractLargeNumbers()
        {
            stuffAndExpect(int.MaxValue.ToString() +"-" + (int.MaxValue-1789).ToString()+"=","1789") ;
            stuffAndExpect("c","0");
            stuffAndExpect((int.MaxValue-4567).ToString() + "-" + (int.MaxValue).ToString()+"=", "-4567");
        }

        [Test]
        public void CanDivideLargeNumbers()
        {
            stuffAndExpect(int.MaxValue.ToString()+"/10000=",(int.MaxValue/10000).ToString());  //not a great test since the test itself could not be as expected
            stuffAndExpect("c","0");
            stuffAndExpect("456456456/10000=","45645");  // this is the floor of integer division. Should really be floating point and accurate

        }

        [Test]
        public void CanMultiplyLargeNumbers()
        {
            Assert.Fail(); // need to write some good test cases here
        }
        //
        //
        [Test]
        public void CanStartNewComputationAfterEquals()
        {
            //  Omitting use of Clear key - assumption is new number after equals is start of new computation
            //  3+4=4+5=   should yield 7 then 9
            stuffAndExpect("3+4=", "7");
            stuffAndExpect("4+5=", "9");
        }

        [Test]
        public void CanStartMultiDigitComputationAfterEquals()
        {
            stuffAndExpect("2342-342=", "2000");
            stuffAndExpect("6000/30=","200");
        }


        // More Tests that are not included:  
        //  These would be crucial for a production system but are of limited value as an academic exercise.

        // - Computations near MinValues
        // - Checking for computations crossing through and using zero (both display and computational checks)
        // - All testing of cases beyond INT precision level
        // - All testing of decimal/floating point use
        // - Suite of tests for scientific notation support

        // Nonstandard/More obscure cases

       
        [Test]
        public void BeyondScope_CanOperateOnLastResult() //beyond scope of this project ??
            //  Understands +=  -=  *= and /=  as operating on last result
            //          1+2+= 6     any number -=  0        4*= 16     any number /=  1
        {
            stuffAndExpect("1+2+=","6");
            stuffAndExpect("c","0");
            stuffAndExpect("45-=","0");
            stuffAndExpect("c", "0");
            stuffAndExpect("4*=","16");
            stuffAndExpect("123/=","1");
        }

        [Test]
        public void CanIgnoreExtraneousOperators()
        {
            stuffAndExpect("1+2+++-1=", "2");
            stuffAndExpect("3-*2+8/-1=", "13");
            stuffAndExpect("33+/11=", "3");
        }

        [Test]
        public void CanIgnoreAbsenceOfOperators()
        {
            stuffAndExpect("13=", "13");
            stuffAndExpect("14=", "14");
            stuffAndExpect("59=", "59");
        }

        // Boundary Conditions and overflows

        [Test]
        public void CanOverflowMaxInt()
        {
            // set first value to just under max int, Add a reasonable value to it to force it over max int
            // check that the return value now is in Scientific Notation
            // 
            // Do the same for the number of display characters on output screen (8-10 chars??)
        }

        [Test]
        void CanUnderflowOnDivide()
        {
            //  Divide until the number extends past the number of chars available on output screen and then
            //  make sure it is converted to Scientific Notation
        }


        [Test]
        public void CanOverflowAtCorrectValue()
        {
        }

              
    }
}
