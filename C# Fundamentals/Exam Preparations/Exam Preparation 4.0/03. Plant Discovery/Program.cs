using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] plantArg = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantArg[0];
                int plantRarity = int.Parse(plantArg[1]);
                if (!plantsRarity.ContainsKey(plantName))
                {
                    //plants.Add(plantName, plantRarity);
                    plantsRarity.Add(plantName, plantRarity);
                    plantsRating.Add(plantName, new List<double>());
                }
                else
                {
                    plantsRarity[plantName] = plantRarity;
                }
            }
            string command = Console.ReadLine();
            while(command != "Exhibition")
            {
                string[] commandArg = command.Split(new char[] {' ', '-', ':'}
                ,StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                string plant = commandArg[1];
                if(commandType == "Rate")
                {
                    double rating = double.Parse(commandArg[2]);
                    if (plantsRating.ContainsKey(plant))
                    {
                        plantsRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if(commandType == "Update")
                {
                    int newRarity = int.Parse(commandArg[2]);
                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(commandType == "Reset")
                {
                    if (plantsRating.ContainsKey(plant))
                    {
                        plantsRating[plant].Clear();
                    }
                    else 
                    {
                        Console.WriteLine("error");
                    }                            
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach(var (plantName,rarity) in plantsRarity)
            {
                if(plantsRating[plantName].Count > 0)
                {
                    double average = plantsRating[plantName].Average();
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:f2}");
                }
                else
                {
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {0:f2}");
                }
               
                
            }
        }
    }
}
