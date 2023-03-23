using System;
using System.Linq;
namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());          
            for(int i = 0; i < numOfRows; i++)
            {
                int sum = 0;
                string input = Console.ReadLine();
                long[] nums = input.Split().Select(long.Parse).ToArray();
                long biggerNum = nums[0] >= nums[1] ? nums[0] : nums[1];
                string numString = biggerNum.ToString();
                int position = numString[0] == '-' ? 1 : 0;
                for(int j = position; j < numString.Length; j++)
                {
                    sum += int.Parse(numString[j].ToString());
                }
                Console.WriteLine(sum);
            }
        }
    }
}
