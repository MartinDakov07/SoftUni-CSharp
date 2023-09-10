using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _11._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                string[] dragonStats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = dragonStats[0];
                string name = dragonStats[1];
                string damage = dragonStats[2];
                string health = dragonStats[3];
                string armor = dragonStats[4];

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, Dragon>());                    
                }
                if (dragons[type].ContainsKey(name))
                {
                    OverWriteStats(dragons, dragonStats);
                }
                else
                {
                    dragons[type].Add(name, new Dragon());//we are setting in the class his stats by default,and if they are not default,we will just overwrite them
                    if(damage != "null")
                    {
                        dragons[type][name].Damage = double.Parse(damage);
                    }
                    if(health != "null")
                    {
                        dragons[type][name].Health = double.Parse(health);
                    }
                    if(armor != "null")
                    {
                        dragons[type][name].Armor = double.Parse(armor);
                    }
                }
            }
            foreach(var dragon in dragons)
            {
                double damage = dragon.Value.Sum(x => x.Value.Damage / dragon.Value.Count);
                double health = dragon.Value.Sum(x => x.Value.Health / dragon.Value.Count);
                double armor = dragon.Value.Sum(x => x.Value.Armor / dragon.Value.Count);
                Console.WriteLine($"{dragon.Key}::({damage:f2}/{health:f2}/{armor:f2})");

                foreach(var stat in dragon.Value)
                {
                    Console.WriteLine($"-{stat.Key} -> damage: {stat.Value.Damage}, health: {stat.Value.Health}, armor: {stat.Value.Armor}");
                }
            }
        }
        public class Dragon
        {
           public double Damage { get; set; }
           public double Health { get; set; }
           public double Armor { get; set; }
           public Dragon()
           {
               Damage = 45;
               Health = 250;
               Armor = 10;
           }
        }
        static void OverWriteStats(Dictionary<string,SortedDictionary<string,Dragon>> dragons, string[] dragonArg)
        {
            string type = dragonArg[0];
            string name = dragonArg[1];
            string damage = dragonArg[2];
            string health = dragonArg[3];
            string armor = dragonArg[4];

            if (damage != "null")
            {
                dragons[type][name].Damage = double.Parse(damage);
            }
            else
            {
                dragons[type][name].Damage = 45;
            }
            if (health != "null")
            {
                dragons[type][name].Health = double.Parse(health);
            }
            else
            {
                dragons[type][name].Health = 250;
            }
            if (armor != "null")
            {
                dragons[type][name].Armor = double.Parse(armor);
            }
            else
            {
                dragons[type][name].Armor = 10;
            }
        }
        
    }
}
