using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

            public int GetBiggestMagnitude(int number1, int number2)
            {
                var result = Math.Max(Math.Abs(number1),Math.Abs(number2));
                return result == Math.Abs(number1) ? number1 : number2;
            }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            var power = Math.Ceiling(Math.Log10(number));
            var result = number*Math.Pow(10, power);
            return (int) result;

        }
    }
}
