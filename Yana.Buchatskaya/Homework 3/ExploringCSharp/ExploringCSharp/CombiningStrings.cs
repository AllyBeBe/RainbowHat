using System;
using System.Text;

namespace ExploringCSharp
{
    public class CombiningStrings
    {
        public string GreetsByCombiningStringsWithPlus(string name)
        {
            return "Hello, " + name;
        }

        public string GreetsByCombiningStringsWithFormats(string name)
        {
            // try googling "string formatting in C#"
            string formatting = "{0,7}" + "{1,6}";
            return String.Format(formatting, "Hello, ", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            var builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder.ToString();
        }
    }
}
