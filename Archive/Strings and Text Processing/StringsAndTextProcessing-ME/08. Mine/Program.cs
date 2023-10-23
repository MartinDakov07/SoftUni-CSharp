using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace _08._Mines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"<(?<firstChar>.)(?<secondChar>.)>");
            MatchCollection matches = pattern.Matches(input);
            List<char> charedMine = input.ToList();
            foreach (Match match in matches)
            {
                string mine = match.Value;
                char first = char.Parse(match.Groups["firstChar"].Value);
                char second = char.Parse(match.Groups["secondChar"].Value);
                int power = (int)Math.Abs((first - second));
                int index = match.Index;
                int bestStart = index - power;
                int bestEnd = index - 1 + 4 + power;//+4 is for removing the mine <AZ> - length 4

                if(bestStart < 0)
                {
                    bestStart = 0;
                }

                if(bestEnd >= charedMine.Count)
                {
                    bestEnd = charedMine.Count - 1;
                }

                for(int i = bestStart; i <= bestEnd; i++)
                {
                    charedMine.RemoveAt(i);
                    charedMine.Insert(i, '_');
                }
            }
            Console.WriteLine(string.Join("",charedMine));
        }
    }
}
