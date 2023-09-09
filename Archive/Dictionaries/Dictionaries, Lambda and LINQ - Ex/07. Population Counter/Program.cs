using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _07._Population_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string command = Console.ReadLine();
            while(command != "report")
            {
                string[] commandArg = command.Split("|");
                string city = commandArg[0];
                string country = commandArg[1];
                long population = long.Parse(commandArg[2]);
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);                    
                }
                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, population);
                }
                command = Console.ReadLine();
            }
            foreach(var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach(var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
