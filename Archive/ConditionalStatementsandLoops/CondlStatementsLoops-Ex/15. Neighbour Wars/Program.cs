using System;

namespace _15._Neighbour_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PeshoPower = int.Parse(Console.ReadLine());
            int GoshoPower = int.Parse(Console.ReadLine());
            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int count = 0;
            while(PeshoHealth > 0 && GoshoHealth > 0)
            {
                count++;
                if (count % 2 != 0)
                {
                    GoshoHealth -= PeshoPower;
                    if(GoshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }                    
                }
                else
                {
                    PeshoHealth -= GoshoPower;
                    if(PeshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }                   
                }
                if(PeshoHealth <= 0 || GoshoHealth <= 0)
                {
                    break;
                }
                if(count % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
                
            }
            if (PeshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {count}th round.");
            }
            else if (GoshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {count}th round.");
            }
        }
    }
}
