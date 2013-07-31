using System.Diagnostics;
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

        [test]
        public void InitialStateIsZero()
        {
            Assert.That(_controller.GetOutput(), Is.EqualTo("0"));
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


        [test]
        public void CanEnterEachDigit()
        {
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("1"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("12"));
            Assert.That(_controller.AcceptCharacter('3'), Is.EqualTo("123"));
            Assert.That(_controller.AcceptCharacter('4'), Is.EqualTo("1234"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("12345"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("123456"));
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("1234567"));
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("12345678"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("123456789"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("1234567890")); // overflow yet???
            Assert.That(_controller.AcceptCharacter('C'), Is.EqualTo("0"));
        }

        [Test]
        public void CanIgnoreLeadingZeros()
        {
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2")); // not "02"
        }

        [test]
        public void CanDoBasicAdd() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('6'), Is.EqualTo("6"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("8"));
        }

        [test]
        public void CanDoMultipleDigitAdd() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("28"));
            Assert.That(_controller.AcceptCharacter('+'), Is.EqualTo("28"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("91"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("119"));
        }


        [test]
        public void CanDoBasicSubtract() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('3'), Is.EqualTo("3"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("4"));
        }

        [test]
        public void CanDoUnarySubtract() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-9"));
        }
               
        [test]
        public void CanGoNegativeOnSubtract() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('7'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("7"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-2"));
        }

        [test]
        public void CanDoBasicMultiply() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('4'), Is.EqualTo("4"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("4"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("20"));
        }

        [test]
        public void CanHandleUnaryMultiply() //    +  -  *  /  =  C
        {
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("0"));
        }

        [test]
        public void CanMultiplyNegative()
        {
            Assert.That(_controller.AcceptCharacter('-'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('*'), Is.EqualTo("-9"));
            Assert.That(_controller.AcceptCharacter('5'), Is.EqualTo("5"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("-45"));
        }

        [Test]
        public void CanDoBasicDivide() 
        {
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('2'), Is.EqualTo("2"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("4"));
        }

        [test]
        public void CanHandleUnaryDivide() 
        {
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('9'), Is.EqualTo("9"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("0"));
        }

        [test]
        public void CatchDivideByZero()
        {      
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("Error:Divide by 0"));  // or some other shorter message
        }

        [test]
        public void CatchNotDivideByZero()
        {
            Assert.That(_controller.AcceptCharacter('8'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('/'), Is.EqualTo("8"));
            Assert.That(_controller.AcceptCharacter('0'), Is.EqualTo("0"));
            Assert.That(_controller.AcceptCharacter('1'), Is.EqualTo("1"));
            Assert.That(_controller.AcceptCharacter('='), Is.EqualTo("8"));
        }

        //  CanPerformMultipleOperations   15+3-8*20=
        //  CanAddLargeNumbers
        //  CanSubtractLargeNumbers
        //  CanDivideLargeNumbers
        //  CanMultiplyLargeNumbers
        //
        //
        //  Omitting use of Clear key - assumption is new number after equals is start of new computation
        //  3+4=4+5=   should yield 7 then 9

        // Nonstandard cases
        //  Understands +=  -=  *= and /=  as operating on last result
        //          1+2+= 6     any number -=  0        4*= 16     any number /=  1

        //  CanIgnoreExtraneousOperators  1+2+++= (6) ;   3-+4  (7)
        //   
        //  CanIgnoreAbsenceOfOperators   13=14=59 (13 then 14 then 59)   

        // Boundary Conditions and overflows

        [test]
        public void CanOverflowMaxInt()
        {
            // set first value to just under max int, Add a reasonable value to it to force it over max int
            // check that the return value now is in Scientific Notation
            // 
            // Do the same for the number of display characters on output screen (8-10 chars??)
        }

        [test]
        void CanUnderflowOnDivide()
        {
            //  Divide until the number extends past the number of chars available on output screen and then
            //  make sure it is converted to Scientific Notation
        }


        [test]
        public void CanOverflowAtCorrectValue()
        {
        }

              
    }
}
