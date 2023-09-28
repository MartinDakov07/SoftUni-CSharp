using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _07.Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptions = 0;
            while (exceptions < 3)
            {
                string[] command = Console.ReadLine().Split();
                string type = command[0];
                if (type == "Replace")
                {
                    int index = 0;
                    try
                    {
                        int checkIndex = int.Parse(command[1]);
                        index = checkIndex;
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    int replace = 0;
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }
                    try
                    {
                        int element = int.Parse(command[2]);
                        replace = element;
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    numbers[index] = replace;
                }
                else if (type == "Print")
                {
                    int startIndex = 0;
                    int endIndex = 0;
                    try
                    {
                        int replaceStart = int.Parse(command[1]);
                        startIndex = replaceStart;
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    try
                    {
                        int replaceEnd = int.Parse(command[2]);
                        endIndex = replaceEnd;
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    if ((startIndex < 0 || startIndex >= numbers.Length) || (endIndex < 0 || endIndex >= numbers.Length))
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        Console.Write($"{numbers[i]}, ");
                    }
                    Console.Write(numbers[endIndex]);
                    Console.WriteLine();
                }
                else if (type == "Show")
                {
                    int index = 0;
                    try
                    {
                        int validIndex = int.Parse(command[1]);
                        index = validIndex;
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }
                    Console.WriteLine(numbers[index]);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
