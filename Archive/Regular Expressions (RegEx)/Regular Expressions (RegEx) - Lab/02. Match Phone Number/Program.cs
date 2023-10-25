using System;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)[2]{1}\1\d{3}\1\d{4}\b";
            string numbers = Console.ReadLine();
            MatchCollection matches = Regex.Matches(numbers, regex);
            var validNums = matches
                .Cast<Match>()
                .Select(v => v.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",validNums));
        }
    }
}
