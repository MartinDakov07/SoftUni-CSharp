using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _06._Square_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> squareNums = new List<int>();
            for(int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)(Math.Sqrt(numbers[i])))
                {
                    squareNums.Add(numbers[i]);
                }
            }
            squareNums.Sort((x,y) => y.CompareTo(x));
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
