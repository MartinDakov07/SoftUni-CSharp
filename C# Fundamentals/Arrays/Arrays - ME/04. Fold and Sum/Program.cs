using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).   
                ToArray();
            int k = numbers.Length / 4;
            int[] upperRow = new int[2 * k];
            int[] lowerRow = new int[2 * k];

            int counter = 0;
            for (int i = k; i < k * 3; i++) lowerRow[counter++] = numbers[i];
            counter = 0;
            for(int i = k - 1; i >= 0; i--) upperRow[counter++] = numbers[i];
            for(int i = 4 * k - 1; i >= 3 * k; i--) upperRow[counter++] = numbers[i];

            for(int i = 0; i < lowerRow.Length; i++)
            {
                Console.Write(lowerRow[i] + upperRow[i] + " ");
            }
        }
    }
}
