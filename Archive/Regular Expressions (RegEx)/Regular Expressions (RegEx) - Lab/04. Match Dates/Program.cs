using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([\/\.\-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, regex);
            foreach(Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
