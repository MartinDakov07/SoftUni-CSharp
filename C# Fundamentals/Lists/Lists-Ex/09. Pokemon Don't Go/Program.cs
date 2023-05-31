using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while(pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int num = 0;
                if(index < 0)
                {
                    num = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if(index > pokemons.Count - 1)
                {
                    num = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    num = pokemons[index];
                    pokemons.RemoveAt(index);
                }                
                for(int i = 0; i <= pokemons.Count - 1; i++)
                {
                    if (pokemons[i] <= num)
                    {
                        pokemons[i] += num;
                    }
                    else if (pokemons[i] > num)
                    {
                        pokemons[i] -= num;
                    }
                }
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
