using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\/|\=)(?<place>[A-Z][A-Za-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            int totalPoints = 0;
            
            List<string> matchItems = new List<string>();
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string kvp = match.Groups["place"].Value;
                    matchItems.Add(kvp);
                    totalPoints += match.Groups["place"].Value.Length;                  
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ",matchItems)}");
            Console.WriteLine($"Travel Points: {totalPoints}");
        }
    }
}
