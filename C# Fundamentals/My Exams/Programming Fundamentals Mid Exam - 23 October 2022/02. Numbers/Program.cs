using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while(command != "Finish")
            {
                string[] commandsInfo = command.Split(" ");
                string argsInfo = commandsInfo[0];
                int value = int.Parse(commandsInfo[1]);
                if(argsInfo == "Add")
                {                   
                    numbers.Add((value));
                }
                else if(argsInfo == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove((value));
                    }                    
                }
                else if(argsInfo == "Replace")
                {
                    int replaceNum = int.Parse(commandsInfo[2]);
                    if (numbers.Contains(value))
                    {
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if(numbers[i] == value)
                            {
                                numbers.RemoveAt(i);
                                numbers.Insert(i, replaceNum);
                                break;
                            }
                        }
                    }
                }
                else if(argsInfo == "Collapse")
                {
                    for(int i = 0; i < numbers.Count; i++)
                    {                       
                        if(numbers[i] < value)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                        
                    }                   
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
