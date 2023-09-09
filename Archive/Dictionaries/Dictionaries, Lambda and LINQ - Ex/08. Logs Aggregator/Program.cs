using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _08._Logs_Aggregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> adresses = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] adress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string ip = adress[0];
                string name = adress[1];
                int duration = int.Parse(adress[2]);
                if (!adresses.ContainsKey(name))
                {
                    adresses.Add(name, new Dictionary<string, int>());
                    adresses[name].Add(ip, duration);
                    continue;
                }
                if (!adresses[name].ContainsKey(ip))
                {
                    adresses[name].Add(ip, duration);
                }
                else
                {
                    adresses[name][ip] += duration;
                }
            }
            foreach(var adress in adresses.OrderBy(x => x.Key))
            {
                Console.Write($"{adress.Key}: {adress.Value.Values.Sum()} [{string.Join(", ",adress.Value.Keys.OrderBy(x=>x))}]");
                Console.WriteLine();
            }
        }
    }
}
