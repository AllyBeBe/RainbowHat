using System;
using Calculator;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    public class SimpleMathOperation
        {
            public SimpleMathOperation()
            {
            }

            public int Add(int a, int b)
            {
                int x = a + b;
                return x;
            }

            public int Subtract(int a, int b)
            {
                int x = a - b;
                return x;
            }

            public int Multiply(int a, int b)
            {
                int x = a*b;
                return x;
            }
        
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            //Error: Cannot divide by zero
        }
        int x = a / b;
        return x;
    }

    [TestFixture]
    public class SimpleMathTest
    {
        private readonly CalculatorController _controller = new CalculatorController();
        
            [Test]
            public void SimpleAdditionTest()
            {
                SimpleMathOperation SMO = new SimpleMathOperation();
                int operandA = Convert.ToInt32(_controller.AcceptCharacter('3'));
                int operandB = Convert.ToInt32(_controller.AcceptCharacter('1'));
                int result = SMO.Add(operandA, operandB);
                Assert.AreEqual(4, result);
            }

            [Test]
            public void SimpleSubtractionTest()
            {
                SimpleMathOperation SMO = new SimpleMathOperation();
                int operandA = Convert.ToInt32(_controller.AcceptCharacter('3'));
                int operandB = Convert.ToInt32(_controller.AcceptCharacter('1'));
                int result = SMO.Subtract(operandA, operandB);
                Assert.AreEqual(2, result);
            }

            [Test]
            public void SimpleMultiplicationTest()
            {
                SimpleMathOperation SMO = new SimpleMathOperation();
                int operandA = Convert.ToInt32(_controller.AcceptCharacter('3'));
                int operandB = Convert.ToInt32(_controller.AcceptCharacter('1'));
                int result = SMO.Multiply(operandA, operandB);
                Assert.AreEqual(3, result);
            }

            [Test]
            public void SimpleDivisionTest()
            {
                SimpleMathOperation SMO = new SimpleMathOperation();
                int operandA = Convert.ToInt32(_controller.AcceptCharacter('3'));
                int operandB = Convert.ToInt32(_controller.AcceptCharacter('1'));
                int result = SMO.Divide(operandA, operandB);
                Assert.AreEqual(3, result);
            }
        }
    }
}
