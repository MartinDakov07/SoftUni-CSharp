using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _11._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;//we dont really need this bool, i just use it to practise bools, cause i dont really use them
            if (numbers.Length == 1)//we have only on the left at index -1, which is considered as 0, and on the right we have index 1 which is invalid and is also considered as value 0
                                    //so our index is 0
            {
                Console.WriteLine(0);
                return;
            }

            for(int i = 0;i < numbers.Length; i++)
            {
                int firstSum = 0;
                int secondSum = 0;
                for(int j = i; j < numbers.Length; j++)//the numbers on the right
                {
                    firstSum += numbers[j];
                }
                for (int k = i; k >= 0; k--)//the numbers on the left
                {
                    secondSum += numbers[k];
                }
                if(firstSum == secondSum)
                {
                    isFound = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
