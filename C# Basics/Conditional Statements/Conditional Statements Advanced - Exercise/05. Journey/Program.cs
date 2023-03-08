using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string region = "";
            switch (season)
            {
                case "summer":
                    place = "Camp";
                    if (budget <= 100)
                    {
                        region = "Bulgaria";
                        budget = budget * 0.3;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        region = "Balkans";
                        budget = budget * 0.4;
                    }
                    break;
                case "winter":
                    place = "Hotel";
                    if (budget <= 100)
                    {
                        region = "Bulgaria";
                        budget = budget * 0.7;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        region = "Balkans";
                        budget = budget * 0.8;
                    }
                    break;
            }
            if (budget >1000)
            {
                place = "Hotel";
                region = "Europe";
                budget = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}
