using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            int unlikesCount = 0;
            while(command != "Stop")
            {
                string[] commandArg = command.Split('-');   
                string commandType = commandArg[0];
                string guest = commandArg[1];
                string meal = commandArg[2];
                if(commandType == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest,new List<string>());   
                        guests[guest].Add(meal);
                    }
                    else
                    {
                        if (!guests[guest].Contains(meal))
                        {
                            guests[guest].Add(meal);
                        }
                    }
                }
                else if(commandType == "Dislike")
                {
                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            guests[guest].Remove(meal);
                            unlikesCount++;
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
                command = Console.ReadLine();               
            }
            foreach(var (guest, meals) in guests)
            {
                Console.WriteLine($"{guest}: {string.Join(", ", meals)}");
            }
            Console.WriteLine($"Unliked meals: {unlikesCount}");
        }
    }
}
