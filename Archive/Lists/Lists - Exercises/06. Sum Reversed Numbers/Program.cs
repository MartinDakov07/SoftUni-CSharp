using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _06._Sum_Reversed_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            long sum = 0;
            foreach(var number in numbers)
            {
                char[] numToChar = number.ToCharArray();
                Array.Reverse(numToChar);
                string num = new string(numToChar);
                long value = long.Parse(num);
                sum += value;
            }
            Console.WriteLine(sum);
        }
    }
}
