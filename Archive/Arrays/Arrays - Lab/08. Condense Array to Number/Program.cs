using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(' ')
                  .Select(int.Parse)
                  .ToArray();
            int[] condensed = new int[numbers.Length - 1];
            while (numbers.Length > 1)//if the length is below 2 (which means there is only one number in the array(our final product) - break the loop
            {
                for (int i = 0; i < numbers.Length - 1; i++)//loop through all numbers
                {
                    condensed[i] = numbers[i] + numbers[i + 1];//add the numbers
                    if (i == condensed.Length - 1)//if we get to end of the summing array, we are gonna give its value to our main array
                                                  //so we can sum them in our new created summing array
                    {
                        numbers = condensed;
                        condensed = new int[numbers.Length - 1];//everytime we get to the end, we decrease our length
                    }
                }
            }
            Console.WriteLine(numbers[0]);//there is only one number left in the array
        }
    }
}
