namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            if (input)
            {
                return false;
            }
            return true;
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            // Use resharper on the above to reduce it to a single line.
            return !input;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            if (input1)
            {
                if (input2)
                {
                    return true;
                }
                return false;
            }
            {
                return false;
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return input1 && input2;
            
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            if (input1)
            {   
                return true;         
            }
            if (input2)
            {
                return true;
            }
            return false;
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 || input2;
            
            // Use resharper on the above to reduce it to a single line.

        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.

            // Men under 25 pay surcharge.

            if (gender == "M" && age < 25)
            {
                return true;
            }

            // People of nontraditional or unspecified gender pay surcharge.

            if (gender == "P" || gender == "O")
            {
                return true;
            }

            // Men 25 & over, & women of any age, do not pay surcharge.

         return false;
        }
           
        }
    }
