﻿namespace ExploringCSharp
{
    public class ExploringConditionals
    {
        public string ConvertsBoolToYesOrNo(bool value)
        {
            return value ? "Yes" : "No";
        }

        public string Value = ConvertsBoolToYesOrNoSingleLine ? "Yes" : "No";
        {
            //Mickey, not sure if I did these correctly but I'm starting to get a feel for resharper, though it will take a little time before I'm comfotable with it.
        // Use ReSharper on the code above to make it a single line.
            // You may want to google "C# the question mark colon operator".
            // My first thought was to google "C# ?:", but it turns out that
            // google doesn't handle pure punctuation that well.
            return "";
        }

        public string DoubleString(string stringToDouble)
        {
            if (stringToDouble == null)
            {
                return null;
            }
            return stringToDouble + stringToDouble;
        }

        public string DoubleStringWithInputValidationPattern(string stringToDouble)
        {
            // Use Resharper on the code above to eliminate the "else" case.  This is a common pattern
            // when you want to do something simple to handle invalid input (like a null string),
            // and have something more complicated to do with normal input.  You just check for
            // the invalid input, and return if you find it.  The rest of the method can be as 
            // complicated as you want, and it doesn't need to be "nested" inside an "else" clause.
            return "";
        }

        public string ComplexConditionUsingElseIf(int value)
        {
            if (value == 0)
            {
                return "Free!";
            }
            if (value == 1)
            {
                return "Cheap as dirt!";
            }
            if (value == 2)
            {
                return "Twice as expensive as dirt...";
            }
            return value == 3 ? "TANSTAAFL: There ain't no such thing as a free lunch." : "Too rich for my blood!";
        }

        public string ComplexConditionUsingReturnsAndIfs(int value)
        {
            // Use Resharper on the above to get rid of all of the "else" clauses
            return "";
        }

        public string ComplexConditionUsingSwitch()
        {
            return ComplexConditionUsingSwitch(0);
        }

        public string ComplexConditionUsingSwitch(int value)
        {
            // use Resharper on the first ComplexCondition to convert the entire thing
            // to a switch statement.
            return "";
        }
    }
}
