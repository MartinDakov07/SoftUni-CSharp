using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace _08._Use_Your_Chains__Buddy
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string pattern = @"(?<=<p>)(.*?)(?=<\/p>)";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder message = new StringBuilder();
            foreach(Match match in matches)
            {
                string text = match.Groups[1].Value;
                text = Regex.Replace(text, @"[^a-z0-9]", " ");
                text = Regex.Replace(text, @"\s+", " ");
                foreach(char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char currChar;
                        if(c <= 109)
                        {
                            currChar = (char)(c + 13);
                        }
                        else
                        {
                            currChar = (char)(c - 13);
                        }
                        message.Append(currChar);
                    }
                    else
                    {
                        message.Append(c);
                    }                                       
                }
            }
            Console.WriteLine(message);
        }
    }
}
