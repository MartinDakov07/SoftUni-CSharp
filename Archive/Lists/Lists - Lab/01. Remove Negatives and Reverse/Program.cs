using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _01._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> allNums = numbers.ToList();
            List<int> nonNegatives = new List<int>();
            for(int i = 0; i< allNums.Count; i++)
            {
                if (allNums[i] > 0)
                {
                    nonNegatives.Add(allNums[i]);
                }
            }
            nonNegatives.Reverse();//You can reverse list like that, but you cant reverse array like that, instead use Array.Reverse(array)
            if(nonNegatives.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",nonNegatives));
            }
        }
    }
}
