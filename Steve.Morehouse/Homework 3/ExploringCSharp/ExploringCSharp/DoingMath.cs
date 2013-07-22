using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            return (number1 > number2 ? number1 : number2);
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            return (Math.Abs(number1) > Math.Abs(number2) ? number1 : number2);
        }

        /*
         * only works for zero and above numbers
         */
        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            if (number <= 10)
            {
                return number*10;
            }
            if (number <= 100)
            {
                return number*100;
            }
            return number*1000;
        }
    }
}
