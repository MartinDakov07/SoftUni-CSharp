using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _05._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while(input != "print")
            {
                string[] commandArg = input.Split();
                string command = commandArg[0];
                if(command == "add")
                {
                    int index = int.Parse(commandArg[1]);
                    int element = int.Parse(commandArg[2]);
                    numbers.Insert(index, element);
                }
                else if(command == "addMany")
                {
                    int index = int.Parse(commandArg[1]);
                    for(int i = 2; i < commandArg.Length; i++)
                    {
                        numbers.Insert(index++, int.Parse(commandArg[i]));
                    }
                }
                else if(command == "contains")
                {
                    int element = int.Parse(commandArg[1]);
                    if (numbers.Contains(element))
                    {
                        int index = numbers.IndexOf(element);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if(command == "remove")
                {
                    int index = int.Parse(commandArg[1]);
                    numbers.RemoveAt(index);
                }
                else if(command == "shift")
                {
                    int times = int.Parse(commandArg[1]);
                    for(int i = 0; i < times; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                 }
                else if(command == "sumPairs")
                {
                    List<int> sumNums = new List<int>();
                    for(int i = 0; i < numbers.Count; i+=2)
                    {
                        if(i+1 >= numbers.Count)
                        {
                            sumNums.Add(numbers[i]);
                            break;
                        }
                        sumNums.Add(numbers[i] + numbers[i + 1]);
                    }
                    numbers = sumNums;
                }
                input = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ",numbers));
            Console.Write("]");
        }
    }
}
