using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int loop = Math.Min(firstList.Count, secondList.Count);
            for(int i = 0; i < loop; i++)
            {
                result.Add(firstList[0]);
                firstList.RemoveAt(0);
                result.Add(secondList[secondList.Count - 1]);
                secondList.RemoveAt(secondList.Count - 1);
            }
            int[] leftovers = firstList.Count == 0 ? secondList.ToArray() : firstList.ToArray();
            int lowerNum = Math.Min(leftovers[0], leftovers[1]);
            int biggerNum = Math.Max(leftovers[0], leftovers[1]);
            result.Sort();
            Console.WriteLine(String.Join(" ",result.Where(x => x < biggerNum && x > lowerNum)));
        }
    }
}
