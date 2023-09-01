using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Globalization;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> oddWords = new Dictionary<string, int>();
            string[] words = Console.ReadLine().Split();
            for(int i = 0; i < words.Length; i++)
            {
                if (!oddWords.ContainsKey(words[i].ToLower()))
                {
                    oddWords.Add(words[i].ToLower(), 1);
                }
                else
                {
                    oddWords[words[i].ToLower()]++;
                }
            }
            Console.WriteLine(string.Join(", ", oddWords.Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)));               
        }
    }
}
