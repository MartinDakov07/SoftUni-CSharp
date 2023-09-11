using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
namespace _02._Odd_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for(int i = 0; i < numbers.Count;i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            double average = numbers.Sum() / numbers.Count;
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
