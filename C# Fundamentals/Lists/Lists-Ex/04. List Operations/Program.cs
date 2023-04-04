using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Insert")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.Insert(index, numToAdd);
                    }
                    
                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                       
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                   
                }
                else if (tokens[0] == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);
                    if(direction == "left")
                    {
                        ListShiftLeft(numbers, count);
                    }
                    else if(direction == "right")
                    {
                        ListShiftRight(numbers, count);
                    }
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
        static bool IsIndexInvalid(List<int> numbers, int index)
         => index < 0 || index >= numbers.Count;
        
         static void ListShiftLeft(List<int> numbers, int count)
         {
            for(int i = 0; i < count; i++)
            {
                int firstNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNum);
            }          
         }
        static void ListShiftRight(List<int> numbers, int count)
        {
            for(int i = 0;  i < count; i++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNum);
            }
            
        }
     
        
    }
}
