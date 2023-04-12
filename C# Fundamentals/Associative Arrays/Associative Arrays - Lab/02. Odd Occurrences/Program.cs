using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach(var word in words)
            {
                string loweredWord = word.ToLower();
                if (counts.ContainsKey(loweredWord))
                {
                      counts[loweredWord]++;
                }
                else
                {
                    counts.Add(loweredWord, 1);
                }
            }
            foreach(var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}
