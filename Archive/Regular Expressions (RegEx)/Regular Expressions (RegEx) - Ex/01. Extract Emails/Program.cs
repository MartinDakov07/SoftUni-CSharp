using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            string input = Console.ReadLine();
            List<Match> emails = new List<Match>();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach(Match match in matches)
            {
                emails.Add(match);
            }
            Console.WriteLine(string.Join(Environment.NewLine,emails.Select(e=>e.Value)));
        }
    }
}
