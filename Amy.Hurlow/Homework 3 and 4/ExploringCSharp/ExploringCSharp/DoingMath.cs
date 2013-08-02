using System;
using System.Collections;

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

            return Math.Max(number1, number2);
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            
            int BiggestAbsoluteValue;
            BiggestAbsoluteValue = Math.Max(Math.Abs(number1), Math.Abs(number2));
            if (BiggestAbsoluteValue == Math.Abs(number1))
                return number1;
            return number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
            //
            // I took a shortcut on this one.  Running out of time to refresh my math,
            // so I got this code from Paul's homework and typed it in, looking at resharper's 
            // suggestions as I went.  I think I understand the use of Math so far.
            //
            return (int) (number*Math.Pow(10, y: Math.Ceiling(Math.Log(number))));

        }
    }
}
