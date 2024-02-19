using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Minor_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> loot = new Dictionary<string, int>();

            string resource = Console.ReadLine();
            while(resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!loot.ContainsKey(resource))
                {
                    loot.Add(resource, 0);
                }
                loot[resource] += quantity;
                resource = Console.ReadLine();
            }
           foreach(var resources in loot)
            {
                Console.WriteLine($"{resources.Key} -> {resources.Value}");
            }
        }
    }
}
