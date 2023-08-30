using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _03._Search_for_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] manipulateNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int get = manipulateNums[0];
            int take = manipulateNums[1];
            int search = manipulateNums[2];
            List<int> manList = new List<int>();
            for(int i = 0; i < get; i++)
            {
                manList.Add(numbers[i]);
            }
            manList.RemoveRange(0, take);
            if (manList.Contains(search))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
