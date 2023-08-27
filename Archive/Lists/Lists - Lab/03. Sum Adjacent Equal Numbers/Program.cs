using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _03._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToList();
            for(int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    double sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveRange(i, 2);
                    numbers.Insert(i, sum);
                    i = -1;
                }
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
