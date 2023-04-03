using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            bool change = false;
            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    numbers.Add(numToAdd);
                    change = true;
                }
                else if (tokens[0] == "Remove")
                {
                    int numToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numToRemove);
                    change = true;
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int numToRemoveAt = int.Parse(tokens[1]);
                    numbers.RemoveAt(numToRemoveAt);
                    change = true;
                }
                else if (tokens[0] == "Insert")
                {
                    int numToInsert = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, numToInsert);
                    change = true;
                }
                else if (tokens[0] == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }                    
                }
                else if(tokens[0] == "PrintEven")
                {
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        
                        if(numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(tokens[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(tokens[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {                        
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                    
                }
                else if (tokens[0] == "Filter")
                {
                    if(tokens[1] == ">")
                    {
                        int number = int.Parse(tokens[2]);
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (tokens[1] == ">=")
                    {
                        int number = int.Parse(tokens[2]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (tokens[1] == "<")
                    {
                        int number = int.Parse(tokens[2]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (tokens[1] == "<=")
                    {
                        int number = int.Parse(tokens[2]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }

                }
                command = Console.ReadLine();
            }
            if (change)
            {
                Console.WriteLine(String.Join(" ",numbers));
            }
           
        }
    }
}
