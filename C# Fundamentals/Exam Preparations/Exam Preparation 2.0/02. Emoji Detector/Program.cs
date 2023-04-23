using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List to keep our emojis for print
            List<string> coolEmojis = new List<string>();
            //read input and calculate our cooltreshold
            string input = Console.ReadLine();
            BigInteger coolTreshold = CalculateTreshold(input);
            //pattern for matches
            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            // checking each match to get ascci value
            foreach(Match match in matches)
            {
                string emoji = match.Groups["emoji"].Value;
                int emojiCoolnes = 0;
                foreach (char ch in emoji)
                {
                    
                    emojiCoolnes += (int)ch;
                }
                if(emojiCoolnes > coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (string emoji in coolEmojis) 
            {
                Console.WriteLine($"{emoji}");
            }

        }
        static BigInteger CalculateTreshold(string input)
        {
            BigInteger coolTreshold = 1;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = (int)c - 48;
                    coolTreshold *= digit;
                }
            }
            return coolTreshold;
        }
    }
}
