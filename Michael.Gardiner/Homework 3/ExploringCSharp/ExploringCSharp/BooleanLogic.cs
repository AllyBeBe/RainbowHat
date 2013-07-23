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
            return input != true;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            return input1 && input2;
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            return input1 && input2;
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            return input1 || input2;
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 || input2;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.
            return false;
        }
    }
}
