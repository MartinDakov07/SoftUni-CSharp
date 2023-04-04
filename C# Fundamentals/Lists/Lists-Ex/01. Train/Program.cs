using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxPassangers = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine();
            while(commands != "end")
            {
                string[] command = commands.Split();
                if(command[0] == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    wagons.Add(numberToAdd);
                }
                else
                {
                    int numberToInsert = int.Parse(command[0]);
                    int num = maxPassangers;
                    for(int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + numberToInsert <=num)
                        {
                            wagons[i] += numberToInsert;
                            break;
                        }
                    }
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));


        }
    }
}
