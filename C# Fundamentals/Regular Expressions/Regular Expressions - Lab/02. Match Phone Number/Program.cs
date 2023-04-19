using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            string[] result = matches
                .Select(x => x.Value)
                .ToArray();
            
             Console.Write(string.Join(", ", result));
            
        }
    }
}
