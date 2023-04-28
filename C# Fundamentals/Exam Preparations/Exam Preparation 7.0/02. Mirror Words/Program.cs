using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, regex);
            Dictionary<string,string> result = new Dictionary<string, string>();
            foreach(Match match in matches)
            {
                string firstWord = match.Groups["first"].Value;
                string secondWord = match.Groups["second"].Value;
                string secondReverse = string.Join("",secondWord.ToCharArray().ToArray().Reverse());
                if(firstWord == secondReverse)
                {
                    result.Add(firstWord,secondWord);
                }
            }
            if(matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if(result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(String.Join(", ",result.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}
