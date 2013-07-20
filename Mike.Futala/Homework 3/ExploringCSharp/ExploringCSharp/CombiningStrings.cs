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
           var s = string.Format("Hello, {0}", name);
          return s;

           
        }

        public StringBuilder GreetsByCombiningStringsWithStringBuilder(string name)
        {
            var builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.

            return builder.Append("Hello ").Append(name);


        }
    }
}
