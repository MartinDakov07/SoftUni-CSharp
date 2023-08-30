using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            while (true)
            {
                string[] commandArg = command.Split();
                if (commandArg[0] == "Odd")
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(x=>x%2!=0)));
                    return;
                }
                else if (commandArg[0] == "Even")
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(x=>x%2==0)));
                    return;
                }
                else if (commandArg[0] == "Delete")
                {
                    int number = int.Parse(commandArg[1]);
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (commandArg[0] == "Insert")
                {
                    int element = int.Parse(commandArg[1]);
                    int index = int.Parse(commandArg[2]);
                    numbers.Insert(index, element);
                }
                command = Console.ReadLine();
            }
        }
    }
}
