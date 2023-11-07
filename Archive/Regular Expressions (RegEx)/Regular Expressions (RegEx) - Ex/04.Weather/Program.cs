using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Collections.Generic;

namespace _04._Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfCities = new Dictionary<string, CityWheather>();
            var pattern = new Regex(@"([A-Z][A-Z])(\d{2}\.\d{1,})([A-Za-z][A-Za-z]+)\|");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                foreach (Match match in pattern.Matches(input))
                {
                    string name = match.Groups[1].Value;
                    var city = new CityWheather()
                    {
                        Temperature = double.Parse(match.Groups[2].Value),
                        Wheather = match.Groups[3].Value
                    };
                    listOfCities[name] = city;
                }
            }
            var ordered = listOfCities.OrderBy(c => c.Value.Temperature);
            foreach (var city in ordered)
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temperature:f2} => {city.Value.Wheather}");
            }
        }
    }
    public class CityWheather
    {
        public double Temperature { get; set; }
        public string Wheather { get; set; }

    }

}
