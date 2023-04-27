using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] commandArg = command.Split(' ');
                string commandType = commandArg[0];
                if(commandType == "swap")
                {
                    int firstIndex = int.Parse(commandArg[1]);
                    int secondIndex = int.Parse(commandArg[2]);
                    int firstNum = numbers[firstIndex];
                    int secondNum = numbers[secondIndex];
                    numbers[firstIndex] = secondNum;
                    numbers[secondIndex] = firstNum;
                }
                else if(commandType == "multiply")
                {
                    int firstIndex = int.Parse(commandArg[1]);
                    int secondIndex = int.Parse(commandArg[2]);
                    int sum = numbers[firstIndex] * numbers[secondIndex];
                    numbers[firstIndex] = sum;
                }
                else if(commandType == "decrease")
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
