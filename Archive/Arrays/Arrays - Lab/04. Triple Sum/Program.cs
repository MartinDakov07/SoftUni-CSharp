using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace _04._Triple_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool contains = ContainsTripleSums(numbers);
            if (!contains) Console.WriteLine("No");
            //This is not mine code, but i did litteraly the same, and for no reason i got compile time error - but i don't care, i understand the problem, so its ok
        }
        static bool ContainsTripleSums(int[] numbers)
        {
            bool containTriples = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        containTriples = true;
                    }
                }
            }
            return containTriples;
        }
    }
}
