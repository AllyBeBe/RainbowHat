namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            return !input;
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            return !input;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            return (input1 && input2);
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            return (input1 && input2);
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            return (input1 || input2);
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return (input1 || input2);
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            /* default is everybody pays */
            bool doesRenterPaySurcharge = true;

            /* identified females get a discount */
            if (gender.StartsWith("F"))
            {
                doesRenterPaySurcharge = false;
            }

            /* identified Males over 25 get a discount*/
            if ((gender.StartsWith("M")) && (age >= 25))
            {
                doesRenterPaySurcharge = false;
            }

            return doesRenterPaySurcharge;
        }
    }
}
