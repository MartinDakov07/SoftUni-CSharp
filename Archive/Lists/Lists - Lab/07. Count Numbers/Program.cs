using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;
namespace _07._Count_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            SortedDictionary<long, int> occurences = new SortedDictionary<long, int>();//Here we keep our nums(for long), and their occurences(for int)
            for(int i = 0; i < numbers.Length; i++)
            {
                if (!occurences.ContainsKey(numbers[i]))                    
                {
                    occurences.Add(numbers[i], 1);
                    for(int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            occurences[numbers[i]]++;
                        }
                    }
                }
            }
            foreach(var occurence in occurences)
            {
                Console.WriteLine($"{occurence.Key} -> {occurence.Value}");
            }
        }
    }
}
