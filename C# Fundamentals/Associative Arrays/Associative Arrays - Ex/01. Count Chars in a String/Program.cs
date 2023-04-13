using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            string[] words = Console.ReadLine()
                .Split(" ")
                .ToArray();
            foreach(string c in words)
            {
                foreach(char ch in c)
                {
                    if (!counts.ContainsKey(ch))
                    {
                        counts.Add(ch, 0);
                    }
                    counts[ch]++;
                }
                
            }
            foreach(var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
