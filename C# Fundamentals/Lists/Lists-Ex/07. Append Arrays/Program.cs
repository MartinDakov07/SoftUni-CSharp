using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            List<string> firstList = input
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            List<int> secondList = new List<int>();
            foreach(string numbers in firstList)
            {
                secondList.AddRange(numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", secondList));
            


        }
    }
}
