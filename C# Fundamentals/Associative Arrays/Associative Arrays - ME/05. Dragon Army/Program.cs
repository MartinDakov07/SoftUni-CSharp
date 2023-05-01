using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _05._Dragon_Army
{
    internal class Program
    {
        public class Dragon
        {
            public Dragon()
            {                
                Damage = 45;
                Health = 250;
                Armor = 10;
            }            
            public double Damage { get; set; }
            public double Health { get; set; }
            public double Armor { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
            for(int i = 0; i < n; i++)
            {
                string[] dragonArg = Console.ReadLine().Split();
                string type = dragonArg[0];
                string name = dragonArg[1];
                string damage = dragonArg[2];
                string health = dragonArg[3];
                string armor = dragonArg[4];

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, Dragon>());
                }
                if (dragons[type].ContainsKey(name))
                {
                    OverWrite(dragons, dragonArg);
                }
                else
                {
                    dragons[type].Add(name, new Dragon());
                    if (damage != "null")
                    {
                        dragons[type][name].Damage = double.Parse(damage);                        
                    }
                    if (health != "null")
                    {
                        dragons[type][name].Health = double.Parse(health);
                    }
                    if (armor != "null")
                    {
                        dragons[type][name].Armor = double.Parse(armor);
                    }
                }
            }
            PrintResult(dragons);
        }
        static void OverWrite(Dictionary<string,SortedDictionary<string,Dragon>> dragons,string[] dragonArg)
        {
            string type = dragonArg[0];
            string name = dragonArg[1];
            string damage = dragonArg[2];
            string health = dragonArg[3];
            string armor = dragonArg[4];
             if(damage != "null")
             {
                dragons[type][name].Damage = double.Parse(damage);
             }
             else
             {
                dragons[type][name].Damage = 45;
             }
             if(health != "null")
             {
                dragons[type][name].Health = double.Parse(health);
             }
             else
             {
                dragons[type][name].Health = 250;
             }
             if(armor != "null")
             {
                dragons[type][name].Armor = double.Parse(armor);
             }
             else
             {
                dragons[type][name].Armor = 10;
             }
        }
        static void PrintResult(Dictionary<string,SortedDictionary<string,Dragon>> dragons)
        {
            foreach(var dragon in dragons)
            {
                double damage = dragon.Value.Sum(x => x.Value.Damage / dragon.Value.Count);
                double health = dragon.Value.Sum(x=> x.Value.Health / dragon.Value.Count);
                double armor = dragon.Value.Sum(x => x.Value.Armor / dragon.Value.Count);
                Console.WriteLine($"{dragon.Key}::({damage:f2}/{health:f2}/{armor:f2})");

                Console.WriteLine(String.Join("\n", dragon.Value
                    .Select(x=>$"-{x.Key} -> damage: {x.Value.Damage}, health: {x.Value.Health}, armor: {x.Value.Armor}")));
            }
        }
    }
}
