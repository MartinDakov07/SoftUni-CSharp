using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03._Match_Hexadecimal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, regex).Cast<Match>().Select(v => v.Value).ToArray();
            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
