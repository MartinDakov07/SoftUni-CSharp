using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string secretMessage = Console.ReadLine();
            List<string> goodChildren = new List<string>();
            while(secretMessage != "end")
            {
                string message = String.Join("",secretMessage
                    .ToCharArray()
                    .Select(x=>(char)(x-key))
                    .ToArray());
                string regex = @"[@](?<name>[A-Za-z]+)[^@!:>-]+[!](?<behaviour>[G|N])[!]";
                MatchCollection matches = Regex.Matches(message, regex);
                if(matches.Count == 0)
                {
                    secretMessage = Console.ReadLine();
                    continue;
                }
                string name = matches[0].Groups["name"].Value;
                string behaviour = matches[0].Groups["behaviour"].Value;
                if(behaviour == "G")
                {
                    goodChildren.Add(name);
                }
                secretMessage = Console.ReadLine();
            }
            Console.WriteLine(String.Join("\n",goodChildren));
        }
    }
}
