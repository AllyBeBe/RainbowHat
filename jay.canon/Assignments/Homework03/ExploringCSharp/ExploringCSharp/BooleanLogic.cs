namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            if (input == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            //            if (input)
            //            {
            //                return false;
            //            }
            //            return true;

            // return input ? false : true;

            // return !input;

            return !input;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            if (input1 == true)
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (input1 == true)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            return input1 == true ? input2 == true : input1 == true && false;
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            // Use resharper on this to reduce it to a single line.
            if (input1 == true)
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 ? input2 == true || true : input2 == true;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.

            switch (gender)
            {
                case "F": //females of any age do not pay extra rental surcharge
                    return false;
                case "M": //males age under 25 pay extra rental surcharge
                    return age < 25 ? true : false;
                case "O": //persons of non-traditional gender age under 25 pay extra rental surcharge
                    return age <= 25 ? true : false;
                case "P": //persons preferring not to state gender age under 25 pay extra rental surcharge
                    return age <= 25 ? true : false;
                default:
                    return true;
            }
        }
    }
}
 
