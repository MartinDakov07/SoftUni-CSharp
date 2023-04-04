using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Change_List
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
                if(tokens[0] == "Delete")
                {
                    int numberToRemove = int.Parse(tokens[1]);                                           
                    numbers.RemoveAll(x => x == numberToRemove);
                    
                    
                }
                else if(tokens[0] == "Insert")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index,numToAdd);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
