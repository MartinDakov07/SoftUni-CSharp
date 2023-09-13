using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.ExceptionServices;

namespace _03._Immune_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            List<string> viruses = new List<string>();
            string virus = Console.ReadLine();
            while(virus != "end")
            {
                int virusStrength = 0;
                int timeToDefeat = 0;
                int minutes = 0;
                int seconds = 0;
                for (int i = 0; i < virus.Length; i++)
                {
                    virusStrength += (int)virus[i];
                }
                virusStrength = virusStrength / 3;
                if (!viruses.Contains(virus))
                {
                     timeToDefeat = virusStrength * virus.Length;
                     minutes = timeToDefeat / 60;
                     seconds = timeToDefeat % 60;
                }
                else
                {
                     timeToDefeat = virusStrength * virus.Length;
                     timeToDefeat = timeToDefeat / 3;
                     minutes = timeToDefeat / 60;
                     seconds = timeToDefeat % 60;
                }
                Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
                if (health - timeToDefeat <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {(int)(health-timeToDefeat)}");
                }
                viruses.Add(virus);
                health -= timeToDefeat;
                health = (int)(health + health * 0.2);
                if(health > 5000)
                {
                    health = 5000;
                }
                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {(int)health}");
        }
    }
}
