using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _10._Pairs_by_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i <=numbers.Length-1; i++)
            {
                //if we start from 0, we will have to make our difference again, even though we found it before
                //example: we have 1 5 3 4 2 with diff 2: we start from index 0 (which is one),
                //then with another loop go through every element after it
                //and at index 2 (3) we find our diff (1+2 = 3)
                //then after looping the first loop we get to index 2 (3)
                //and if we start from 0 we need to check again our difference (3-2 = 1), but thats not our problem
                //so thats why we check all the nums after our index, to make sure we wont find the same difference!
                for (int j = i; j <= numbers.Length-1; j++)
                {
                    if (numbers[i] + difference == numbers[j] || numbers[i] - difference == numbers[j])
                    {
                        count++;
                    }
                }                
            }
            Console.WriteLine(count);
        }
    }
}
