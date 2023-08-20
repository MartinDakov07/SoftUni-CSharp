using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _06._Heists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] jewelAndGold = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long priceForJew = jewelAndGold[0];
            long priceForGold = jewelAndGold[1];
            long totalPrice = 0;
            long expenses = 0;
            string command = Console.ReadLine();
            while(command != "Jail Time")
            {
                string[] heist = command.Split();
                string loot = heist[0];
                long expense = long.Parse(heist[1]);
                for(int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        totalPrice += priceForJew;
                    }
                    else if (loot[i] == '$')
                    {
                        totalPrice += priceForGold;
                    }
                }
                expenses += expense;
                command = Console.ReadLine();
            }
            if(totalPrice >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalPrice-expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses-totalPrice}.");
            }
        }
    }
}
