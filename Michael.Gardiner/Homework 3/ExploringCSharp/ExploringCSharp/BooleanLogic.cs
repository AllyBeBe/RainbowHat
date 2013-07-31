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
                       switch (gender)
           {
               case "F":
                   return false;
                case "M":
                   return age < 25 ? true : false;
               default:
                  return true;
        }
             return false;

        }
    }
}
