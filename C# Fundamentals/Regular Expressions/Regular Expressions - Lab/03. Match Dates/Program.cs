using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection dates = Regex.Matches(input, pattern);
            foreach(Match date in dates)
            {
                //var day = date.Groups["day"].Value;
                //var month = date.Groups["month"].Value;
                //var year = date.Groups["year"].Value;
                Console.Write($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value} ");
                Console.WriteLine();
            }
        }
    }
}
