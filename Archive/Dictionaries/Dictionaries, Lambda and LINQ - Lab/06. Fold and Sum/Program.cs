using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _06._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            // Creation of the third array

            int[] thirdFoldedArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                thirdFoldedArray[i] = numbers[k - 1 - i];//we will start from the last num before the k main numbers, and with the -i we will go on the left to get the other numbers
                thirdFoldedArray[k + i] = numbers[4 * k - 1 - i];//here we add our last k nums in new array, while getting from our main array the last nums, after the k numbers
                //1 2 3 4 5 6 7 8 - we have length 8, that means k will be 2 - so we start from index 2(which is 3),and if we double it we will go to index 6(because 2*2 = 4, so 4+2=6)
                //so, to get the numbers before this k numbers, we first get the ones before them by simply substracting by 1(so we can get the index, before the index of the first k num)
                //in our case 3 is on index(2), but this is k num, so to get 2(which is on index 1) we just substract by 1,and then to get 1(0 index),we substract it with i,which will increase after every loop(we go on left)
                //and to get the nums on the right of k nums, we need to get our k index and multiply it by 4, so we can get to the last index(in our case k is 2, and 2*4 = 8,which basically comes as our length,so to get the last num
                //we again substract with 1, which get us on index 7(this goes for num 8), and to get to num 7(index 6),we will still decrease it with i,which will increase every loop(again,we go on left))
                // and this is the explanation of my solution to this problem
            }

            // Creation of the second/middle array and direct printing -> no result/sum array needed

            int[] secondArray = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                secondArray[i] = numbers[i + k];//get the k nums
                Console.Write($"{thirdFoldedArray[i] + secondArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}
