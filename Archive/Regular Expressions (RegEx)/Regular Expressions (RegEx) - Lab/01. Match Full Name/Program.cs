using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Tracing;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]+ [A-Z][a-z]+\b)";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);
            foreach(Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
            Console.WriteLine();
        }
    }
}
