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
            return string.Format("Hello, {0}", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100); // Resharper and MSDN best practices want me to use VAR ;)
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            builder.Append("Hello, ");
            builder.Append(name);
            return builder.ToString(); //wanted to debug this, but couldn't figure out how.  Thought about "stepping into" and the output window, but it didn't work. :(
        }
    }
}
