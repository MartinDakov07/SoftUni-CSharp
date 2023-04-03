using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._List_Manipulation_Basics
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
            while(command != "end")
            {
                string[] tokens = command.Split();
                if(tokens[0] == "Add")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    numbers.Add(numToAdd);
                }
                else  if(tokens[0] == "Remove")
                {
                    int numToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numToRemove);
                }
                else  if(tokens[0] == "RemoveAt")
                {
                    int numToRemoveAt = int.Parse(tokens[1]);
                    numbers.RemoveAt(numToRemoveAt);
                }
                else if(tokens[0] == "Insert")
                {
                    int numToInsert = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index,numToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
