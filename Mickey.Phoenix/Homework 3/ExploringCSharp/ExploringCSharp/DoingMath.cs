using System;
using System.Diagnostics;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            // Pseudocode (informal, i.e. human-readable but not computer-readable, code):
            // If number1 is greater than number2, return number1.  If number2 is the larger, return number2

//            if (number1 > number2)
//                return number1;
//            else
//            {
//                Console.WriteLine("Whoops, got the else case!!!");
//                return number2;
//            }

            // Shape of the if-statement (the "else <else-statement>" part is optional)
//            if (<conditional>)
//                <then-statement>
//            else
//                <else-statement>


            // Style VERY VERY WRONG: omitting braces
//            if (number1 > number2)
//                return number1;
//            else
//                return number2;

            // Style 1: each on its own line
//            if (number1 > number2)
//            {
//                return number1;
//            }
//            else
//            {
//                return number2;
//            }

            // Style 2: save vertical lines, braces go on the same line as the control structures
//            if (number1 > number2) {
//                return number1;
//            } else {
//                return number2;
//            }

            // Because of the curly braces, adding the debugging statement does not break the control flow of the program.
            // The return statement is still controlled by the if-statement.
//            if (number1 == number2)
//            {
//                Console.WriteLine("Debugging here");
//                return -1;
//            }

            // In this case, the "else" is necessary, so that we don't always run the "result = number2" line
//            int result;
//            if (number1 > number2)
//            {
//                result = number1;
//            }
//            else
//            {
//                result = number2;
//            }
//            return result;

            // In this case, the "else" is not necessary, because we'll never run the "return number2" line if we've
            // already run the "return number1" line (since "return" ends the execution of the method).
//            if (number1 > number2)
//            {
//                return number1;
//            }
//            else
//            {
//                return number2;
//            }

//            if (number1 > number2)
//            {
//                return number1;
//            }
//            return number2;

//            return (number1 > number2) ? number1 : number2;

            return Math.Max(number1, number2);

            // Side note: the following comment is now obsolete.  The current version of ReSharper no longer has this annoying behavior...
            // ...when you type "Math.", it automatically includes the "using System.Math", and does not try to auto-correct "Math." to
            // "DoingMath.".  Yay, ReSharper!
            
            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            return 0;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
            return 0;
        }
    }
}
