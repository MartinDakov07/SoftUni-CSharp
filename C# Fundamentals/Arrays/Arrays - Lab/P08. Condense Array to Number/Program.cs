using System;
using System.Linq;
namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[numbers.Length-1];
            while(numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                    if(i == condensed.Length - 1)
                    {
                        numbers = condensed;
                        condensed = new int [numbers.Length - 1];
                    }
                    
                }
            }           
            Console.WriteLine(numbers[0]);
            //int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //int[] condenced = new int[nums.Length - 1];
            //
            //while (nums.Length > 1)
            //{
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        condenced[i] = nums[i] + nums[i + 1];
            //        if (i == condenced.Length - 1)
            //        {
            //            nums = condenced;
            //            condenced = new int[nums.Length - 1];
            //        }
            //    }
            //}
            //Console.WriteLine(nums[0]); //nums.Length = 1 -> index = 0 

        }
    }
}
