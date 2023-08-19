using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _04._Grab_and_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());
            bool isFound = false;
            int sum = 0;
            int index = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    index = i;
                    isFound = true;
                }
            }
            if (isFound)
            {
                for(int i = index;i >= 0; i--)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
            
        }
    }
}
