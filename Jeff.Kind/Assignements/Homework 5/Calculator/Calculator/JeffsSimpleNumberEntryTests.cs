using System;
using NUnit.Framework;

namespace CalculatorControllerTests
{
    // Create a comprehensive and correct set of automated tests for CalculatorController, such that, were they all made to pass, a calculator based on CalculatorController would function “correctly”.
    [TestFixture]
    public class JeffSimpleNumberEntryTests : BaseTestFixture
    {
        // This test will verify the entry of large digits
        +        [Test]
+        public void CanEnterLargeDigits()
+        {
+            EnterNumber(1);
+            AssertOutput("1");
+            EnterNumber(2);
+            AssertOutput("12");
+            EnterNumber(3);
+            AssertOutput("123");
+            EnterNumber(4);
+            AssertOutput("1234");
+            EnterNumber(5);
+            AssertOutput("12345");
+            EnterNumber(6);
+            AssertOutput("123456");
+            EnterNumber(7);
+            AssertOutput("1234567");
+            EnterNumber(8);
+            AssertOutput("12345678");
+            EnterNumber(9);
+            AssertOutput("123456789");
+            EnterNumber(0);
+            AssertOutput("1234567890");
+        }

    // this test will verify that small single digit numbers can be added
        [Test]
        public void CanAddSmallNumbers()
        {
            EnterNumber(2);
            AcceptCharacters("+");
            EnterNumber(1);
            AcceptCharacters("=");

            AssertOutput("3");
        }

       // this test will verify that multi-digit numbers can be added
        [Test]
        public void CanAddSmallNumbers()
        {
            EnterNumber(22);
            AcceptCharacters("+");
            EnterNumber(41);
            AcceptCharacters("=");

            AssertOutput("63");
        }

        //Tests basic division resulting in fraction
+        [Test]
+        public void CanDoDivision()
+        {
+            EnterNumber(64);
+            AcceptCharacters("/");
+            EnterNumber(5);
+            AcceptCharacters("=");
+            AssertOutput("12.8");
+        }
    +      // Tests numbers can be divided by zero 
        [Test]
+        public void CanDivideZeroByAnyNumber()
+        {
+            EnterNumber(0);
+            AcceptCharacters("/");
+            EnterNumber(64);
+            AcceptCharacters("=");
+            AssertOutput("0");


               
