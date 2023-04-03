using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int a = Math.Min(firstList.Count, secondList.Count);//firstList = 5, secondList = 6 -> Math.Min = 5
            for(int i = 0; i < a; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if(firstList.Count > secondList.Count)
            {
                for(int i = a; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if(secondList.Count > firstList.Count)
            {
                for (int i = a; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
