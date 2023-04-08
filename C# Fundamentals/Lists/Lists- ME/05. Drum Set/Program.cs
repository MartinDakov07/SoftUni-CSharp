using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumQuality = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> firstValues = new List<int>(drumQuality);
            string command = Console.ReadLine();
            while(command != "Hit it again, Gabsy!")
            {
                int powerAplied = int.Parse(command);
                
                for(int i = 0; i < drumQuality.Count; i++)
                {
                    drumQuality[i] -= powerAplied;                   
                }
                for(int i = 0; i < drumQuality.Count; i++)
                {
                    int drumPrice = firstValues[i] * 3;
                    if (drumQuality[i] <= 0)
                    {
                        if(savings - drumPrice >= 0)
                        {
                            drumQuality[i] = firstValues[i];
                            savings -= firstValues[i] * 3;
                        }
                        else
                        {
                            drumQuality.RemoveAt(i);
                            firstValues.RemoveAt(i);
                            i--;
                        }
                    }
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", drumQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
