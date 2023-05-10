using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;
namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wholeMessage = Console.ReadLine().Split('|');
            //pattern for capital letters: ([#$%*&])(?<capitalLetters>[A-Z]{1,})\1
            //pattern for lenght and ascii values: (?<asciiCode>[\d]{2}):(?<lenght>[\d]{2})
            char[] capitalLetters = GetCapitalLetters(wholeMessage[0]);
            Dictionary<char, int> length = GetLength(capitalLetters, wholeMessage[1]);
            List<string> validWords = ValidateWords(wholeMessage[2],length);
            for(int i = 0; i< capitalLetters.Length; i++)
            {
                Console.WriteLine(validWords.Find(x=>x[0] == capitalLetters[i]));
            }
        }
        private static List<string> ValidateWords(string input,Dictionary<char,int> lenghtAndFirstWord)
        {
            string[] allWords = input.Split();
            List<string> validWords = new List<string>();
            foreach(var word in allWords)
            {
                char firstLetter = word[0];
                if(lenghtAndFirstWord.ContainsKey(firstLetter)&&lenghtAndFirstWord[firstLetter] == word.Length)
                {
                    validWords.Add(word);
                }
            }
            return validWords;
        }
        private static char[] GetCapitalLetters(string input)
        {
            string regex = @"([#$%*&])(?<capitalLetters>[A-Z]{1,})\1";
            MatchCollection matches = Regex.Matches(input, regex);
            string result = string.Empty;
            for (int i = 0; i < matches.Count; i++)
            {
                result += matches[i].Groups["capitalLetters"].Value;
            }
            return result.ToCharArray();
        }
        private static Dictionary<char, int> GetLength(char[] capitalLetters, string input)
        {
            Dictionary<char, int> lenghtByFirstWord = new Dictionary<char, int>();
            string regex = @"(?<asciiCode>[\d]{2}):(?<lenght>[\d]{2})";
            MatchCollection matches = Regex.Matches(input, regex);
            foreach (Match match in matches)
            {
                char symbol = (char)int.Parse(match.Groups["asciiCode"].Value);
                int lenght = 1 + int.Parse(match.Groups["lenght"].Value);
                if (capitalLetters.Contains(symbol))
                {
                    if (lenghtByFirstWord.ContainsKey(symbol))
                    {
                        lenghtByFirstWord[symbol] = lenght;
                    }
                    else
                    {
                        lenghtByFirstWord.Add(symbol, lenght);
                    }
                }
            }
            return lenghtByFirstWord;
        }
    }
}       
    

