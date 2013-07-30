using System;
using System.Runtime.Remoting.Messaging;

namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            return input != true;
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            // Use resharper on the above to reduce it to a single line.
            return input != true;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            switch (input1)
            {
                case true:
                    return input2;
                default:
                    return false;
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            switch (input1)
            {
                case true:
                    return input2;
                default:
                    return false;
            }
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            // Use resharper on this to reduce it to a single line.
            return input1 || input2;
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return input1 || input2;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.

            if ("M".Equals(gender) && age < 25)
                return true;
            if ("O".Equals(gender))
                return true;
            if ("P".Equals(gender))
                return true;

            return false;
            }
        }
    } 

