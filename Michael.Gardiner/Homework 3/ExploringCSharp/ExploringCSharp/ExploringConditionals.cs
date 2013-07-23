namespace ExploringCSharp
{
    public class ExploringConditionals
    {
        public string ConvertsBoolToYesOrNo(bool value)
        {
            return value ? "Yes" : "No";
        }

        public string ConvertsBoolToYesOrNoSingleLine(bool value)
        {
            return value ? "Yes" : "No";
        }

        public string DoubleString(string stringToDouble)
        {
            return stringToDouble == null ? null : stringToDouble + stringToDouble;
        }

        public string DoubleStringWithInputValidationPattern(string stringToDouble)
        {
            return stringToDouble == null ? null : stringToDouble + stringToDouble;
        }

        public string ComplexConditionUsingElseIf(int value)
        {
            switch (value)
            {
                case 0:
                    return "Free!";
                case 1:
                    return "Cheap as dirt!";
                case 2:
                    return "Twice as expensive as dirt...";
                case 3:
                    return "TANSTAAFL: There ain't no such thing as a free lunch.";
                default:
                    return "Too rich for my blood!";
            }
        }

        public string ComplexConditionUsingReturnsAndIfs(int value)
        {
            switch (value)
            {
                case 0:
                    return "Free!";
                case 1:
                    return "Cheap as dirt!";
                case 2:
                    return "Twice as expensive as dirt...";
                case 3:
                    return "TANSTAAFL: There ain't no such thing as a free lunch.";
                default:
                    return "Too rich for my blood!";
            }
        }

        public string ComplexConditionUsingSwitch(int value)
        {
            switch (value)
            {
                case 0:
                    return "Free!";
                case 1:
                    return "Cheap as dirt!";
                case 2:
                    return "Twice as expensive as dirt...";
                case 3:
                    return "TANSTAAFL: There ain't no such thing as a free lunch.";
                default:
                    return "Too rich for my blood!";
            }
        }
    }
}
