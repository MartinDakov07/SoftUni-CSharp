using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> treasure = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while(command != "Yohoho!")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                if(commandType == "Loot")
                {
                    for(int i = 1; i < commandArg.Length; i++)
                    {
                        if (!treasure.Contains(commandArg[i]))
                        {

                            treasure.Insert(0, commandArg[i]);
                        }
                    }
                }
                else if(commandType == "Drop")
                {
                    int index = int.Parse(commandArg[1]);
                    
                    if(index >= 0 && index < treasure.Count)
                    {
                        foreach(string t in treasure)
                        {
                            int indexOfI = treasure.IndexOf(t);
                            if(indexOfI == index)
                            {
                                treasure.RemoveAt(indexOfI);
                                treasure.Add(t);
                                break;
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;                       
                    }
                }
                else if(commandType == "Steal")
                {
                    int count = int.Parse(commandArg[1]);
                    List<string> stealedItems = new List<string>(); 
                    if(treasure.Count >= count)
                    {
                        for (int i = count; i > 0; i--)
                        {
                            stealedItems.Add(treasure[treasure.Count - i]);
                            treasure.Remove(treasure[treasure.Count - i]);
                        }
                    }
                    else
                    {
                        treasure.RemoveRange(0,treasure.Count-1);
                    }                   
                    Console.WriteLine(string.Join(", ", stealedItems));
                }
                command = Console.ReadLine();   
            }
            double averageLength = 0;
            foreach(string item in treasure)
            {
                averageLength += item.Length;
            }
            averageLength = averageLength / treasure.Count;
            if(treasure.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageLength:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
