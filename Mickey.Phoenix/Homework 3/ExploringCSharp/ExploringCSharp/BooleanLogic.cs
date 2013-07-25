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
            // Use resharper on the above to reduce it to a single line.
            return false;
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
            // Use resharper on the above to reduce it to a single line.
            return false;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            bool isUnknownGender = (gender == "P" || gender == "O");
            bool isYoungMan = (gender == "M" && age < 25);

            return isUnknownGender || isYoungMan;
        }

        // Use the "Boolean or" operator ("||") to combine the two halves of the logical expression.
        //            if (gender == "P" || gender == "O")
        //            {
        //                return true;
        //            }

        // Use the "Boolean and" operator ("&&") to combine the two halves of the logical expression.
        //            if (gender == "M" && age < 25)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

    }
}
