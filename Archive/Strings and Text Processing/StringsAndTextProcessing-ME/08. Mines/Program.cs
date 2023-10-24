using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
namespace _08._Mines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"<(?<firstChar>[A-Za-z])(?<secondChar>[A-Za-z])>");
            MatchCollection matches = pattern.Matches(input);
            foreach(Match match in matches)
            {
                string mine = match.Value;
                char first = char.Parse(match.Groups["firstChar"].Value);
                char second = char.Parse(match.Groups["secondChar"].Value);
                int power = (int)(first - second);
                int index = match.Index;
                for(int i = index - power; i < index + 4 + power; i++)
                {
                    input = input.Replace(input[i], '_');
                }
            }
            Console.WriteLine(input);
        }
    }
}
