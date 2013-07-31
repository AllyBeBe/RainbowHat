using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
            int maxNumber = Math.Max(number1, number2);
            return maxNumber;
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            int abs1 = Math.Abs(number1);
            int abs2 = Math.Abs(number2);

            if (abs1 > abs2)
            {
                return number1;
            }

            return number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).

            //reffered to someone's checked in code to solve this.
            int power = (int) Math.Ceiling(Math.Log10(number));
            int result = number*(int) Math.Pow(10, power);
            return result;
        }
    }
}
