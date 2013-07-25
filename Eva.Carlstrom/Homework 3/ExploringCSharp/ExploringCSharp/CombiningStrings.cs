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

            // What kind of functionality makes any sense at all here?  I guess I could play around with padding.

            // This is intended to produce "Hello, " left-aligned and the name right-aligned.  I'm not sure whether it does that.

            const string format = "{0, -10} {1, 10}";
            if (name != null)
            {
                string line1 = string.Format(format, "Hello, ", name);
                Console.WriteLine(line1);
            }
            return null;
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            
            // I have no idea what to make of the auto-complete options.  I have no context for what any of these would do and how they might apply to producing a greeting with someone's name in it.

            // Okay, I'm thinking Equals is applicable.  In NetHack, if you get caught in the vault, the guard asks your name, and kicks you out unless you answer "Croesus", in which case the guard says, "Oh, of course, sir.  So sorry to have disturbed you."
            // So I could do that--check if the name equals a particular value & respond accordingly.  But I still don't see how to use it.  It's not letting me just grab options from the dropdown menu like I expected, and the syntax it seems to be showing me doesn't match the bit I've already done.

            builder.Equals()
            return builder.ToString();
        }
    }
}
