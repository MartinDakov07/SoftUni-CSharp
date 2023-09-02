using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _04._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();            
            Console.WriteLine(string.Join(" ",numbers.OrderByDescending(x=>x).Take(3)));//It will order the nums in descending - 1 2 3 4 5 -> 5 4 3 2 1 and then just take the first 3
        }
    }
}
