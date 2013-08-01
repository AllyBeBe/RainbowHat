//tried adding "using System.Math" here, but after typing System.M - math wasn't recognized.

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
            
            // typing math gave me a list of Math then DoingMath, so I didn't get the issue.

            return Math.Max(number1, number2);

        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number" 
            int abs1 = Math.Abs(number1);
            int abs2 = Math.Abs(number2);
            int val = Math.Max(abs1, abs2);
            return val == abs1 ? number1 : number2;

        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).

            // Well three out of seven - fails with 101 and all 10s.  Last math class I took around 20 years ago was community college algebra. And now I have a headache.

            double x = Math.Log(number,10);
            double y = Math.Pow(10, Math.Round(x));
            double retval = number*y;
            return (int) retval;
        }
    }
}
