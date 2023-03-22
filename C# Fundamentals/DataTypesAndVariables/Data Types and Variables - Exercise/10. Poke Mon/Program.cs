using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokedTargets = 0;
            int maxN = n;
            
            while (n >= m)
            {
                n = n - m;
                pokedTargets++;
                if (n == maxN * 0.50)
                {
                    if(y!=0)
                    {
                        n = (int)(n / y);                                                
                    }
                    else
                    {
                        continue;
                    }                   
                }                              
                                                   
            }
            Console.WriteLine($"{n}");
            Console.WriteLine($"{pokedTargets}");
        }
    }
}
