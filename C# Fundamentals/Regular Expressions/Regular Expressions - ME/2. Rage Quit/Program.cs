using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> collectSymbols = new List<char>();
            StringBuilder rageText = new StringBuilder();
            string text = Console.ReadLine().ToUpper();
            string pattern = @"(?<string>[^\d]+)(?<number>[\d]+)";
            MatchCollection matches = Regex.Matches(text, pattern);                      
            string eachSymbol = @"(\D)";
            MatchCollection findAllSymbols = Regex.Matches(text, eachSymbol);            
            foreach (Match match in matches)
            {                 
                rageText.Append(GetRepeatingText(match));               
            }
            collectSymbols = GetSymbolCount(collectSymbols, rageText.ToString());
            Console.WriteLine($"Unique symbols used: {collectSymbols.Count}");
            Console.WriteLine($"{rageText}");
        }
        static List<char> GetSymbolCount(List<char> collectSymbols,string rageText)
        {
            foreach (char c in rageText)
            {
                if(c >= '0' && c <= '9')
                {
                    continue;
                }
                if (!collectSymbols.Contains(c))
                {
                    collectSymbols.Add(c);
                }
            }
            return collectSymbols;
        }
        static string GetRepeatingText(Match match)
        {
            StringBuilder sb = new StringBuilder();
            string rage = match.Groups["string"].Value;
            int repeat = int.Parse(match.Groups["number"].Value);
            for (int i = 0; i < repeat; i++)
            {
                sb.Append(rage);
            }
            return sb.ToString();
        } 
    }
}
