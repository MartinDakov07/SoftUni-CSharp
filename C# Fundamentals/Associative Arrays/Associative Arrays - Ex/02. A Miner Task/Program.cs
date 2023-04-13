using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource!= "stop")
            {               
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
                resource = Console.ReadLine();
            }
            foreach(var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
