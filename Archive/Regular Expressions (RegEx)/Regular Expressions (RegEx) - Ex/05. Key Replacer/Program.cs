using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
namespace _05._Key_Replacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();
            Match keyPattern = Regex.Match(keyInput, @"(?<startKey>\w+)[\<\|\\]\w+[\<\|\\](?<endKey>\w+)");
            string start = keyPattern.Groups["startKey"].Value;
            string end = keyPattern.Groups["endKey"].Value;
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(" + start + @"(?<word>.{0,}?)" + end + @")");
            MatchCollection matches = pattern.Matches(input);
            StringBuilder message = new StringBuilder();
            foreach(Match match in matches)
            {
                message.Append(match.Groups["word"].Value);
            }
            if(message.Length != 0)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
