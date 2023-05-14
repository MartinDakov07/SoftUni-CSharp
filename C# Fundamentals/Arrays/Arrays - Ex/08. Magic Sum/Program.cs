using System;
using System.Linq;
using System.Collections.Generic;
namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split();                
            int result = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < numbers.Length; i++)
            {
                string[] uniqueNumbers = new string[2];
                for (int j = i+1;j < numbers.Length; j++)
                {
                    if(int.Parse(numbers[i]) + int.Parse(numbers[j]) == result)
                    {
                        if(uniqueNumbers.Contains(numbers[i]) && uniqueNumbers.Contains(numbers[j]))
                        {
                            break;
                        }
                        else
                        {
                            uniqueNumbers[0]=numbers[i];
                            uniqueNumbers[1]=numbers[j];
                            Console.WriteLine($"{uniqueNumbers[0]} {uniqueNumbers[1]}");
                        }
                    }
                }
                
            }
        }
    }
}
