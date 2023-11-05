using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02._Extract_Sentences_by_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Regex pattern = new Regex($@"\b[^?.!]*\b{word}\b[^?.!]*");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                string sentence = match.Value.Trim();
                Console.WriteLine(sentence);
            }

        }
    }
}
