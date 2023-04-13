using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carInfo = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] carArg = Console.ReadLine().Split(' ');
                string command = carArg[0];
                string name = carArg[1];
                
                if(command == "register")
                {
                    string license = carArg[2];
                    if (!carInfo.ContainsKey(name) )
                    {
                        carInfo.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                    
                    else if (carInfo.ContainsKey(name) && carInfo.ContainsValue(license))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
               
                if(command == "unregister")
                {
                    if (!carInfo.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        carInfo.Remove(name);
                    }
                }
            }
            foreach(var car in carInfo)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
