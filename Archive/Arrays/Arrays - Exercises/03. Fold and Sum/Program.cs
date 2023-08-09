using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _03._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = firstArray.Length / 4;

            // Creation of the third array

            int[] thirdFoldedArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                thirdFoldedArray[i] = firstArray[k - 1 - i];//we will start from the last num before the k main numbers, and with the -i we will go on the left to get the other numbers
                thirdFoldedArray[k + i] = firstArray[4 * k - 1 - i];
            }

            // Creation of the second/middle array and direct printing -> no result/sum array needed

            int[] secondArray = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                secondArray[i] = firstArray[i + k];
                Console.Write($"{thirdFoldedArray[i] + secondArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}
