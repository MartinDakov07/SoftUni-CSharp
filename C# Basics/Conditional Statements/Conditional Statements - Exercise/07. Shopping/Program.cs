using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zapisvame si ot konzolata broqt na Budgeta na Petyr i broikite na produktite 
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            //namirane na cena za video kartata
            int gpuPrice = gpu * 250;
            //cena za procesora
            double sumForCpus = cpu * gpuPrice * 0.35;
            // cena za Ram pametta
            double sumForRam = ram * gpuPrice * 0.10;
            double totalPrice = gpuPrice + sumForCpus + sumForRam;  ;
            if (gpu > cpu) // budget - totalPrice
            {
                totalPrice *= 0.85;
            }
            if (budget >= totalPrice)
            {
               
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
