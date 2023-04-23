using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesWithHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesWithMP = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroeArg = Console.ReadLine().Split(' ');
                string heroeName = heroeArg[0];
                int heroeHP = int.Parse(heroeArg[1]);
                int heroeMP = int.Parse(heroeArg[2]);
                heroesWithHP[heroeName] = heroeHP;
                heroesWithMP[heroeName] = heroeMP;
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] commandArg = command.Split(" - ");
                string commandType = commandArg[0];
                string heroName = commandArg[1];
                if (commandType == "CastSpell")
                {
                    
                    int manaNeeded = int.Parse(commandArg[2]);
                    string spellName = commandArg[3];
                    if(manaNeeded <= heroesWithMP[heroName])
                    {
                        heroesWithMP[heroName] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesWithMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if(commandType == "TakeDamage")
                {
                    
                    int damage = int.Parse(commandArg[2]);
                    string attacker = commandArg[3];
                    heroesWithHP[heroName] -= damage;
                    if(heroesWithHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesWithHP[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroesWithHP.Remove(heroName);
                        heroesWithMP.Remove(heroName);
                    }
                }
                else if(commandType == "Recharge")
                {
                    
                    int amount = int.Parse(commandArg[2]);
                   
                    if(heroesWithMP[heroName] + amount  > 200)
                    {
                        amount = 200 - heroesWithMP[heroName];
                    }
                    heroesWithMP[heroName] += amount;
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if(commandType == "Heal")
                {
                    
                    int amountHeal = int.Parse(commandArg[2]);
                    
                    if(heroesWithHP[heroName] + amountHeal > 100)
                    {
                        amountHeal = 100 - heroesWithHP[heroName];
                    }
                    heroesWithHP[heroName] += amountHeal;
                    Console.WriteLine($"{heroName} healed for {amountHeal} HP!");
                }
                command = Console.ReadLine();
            }
            foreach(var kvp in heroesWithHP)
            {
                string heroName = kvp.Key;
                int heroHP = kvp.Value;
                int heroMP = heroesWithMP[heroName];
                Console.WriteLine(heroName);
                Console.WriteLine($"  HP: {heroHP}");
                Console.WriteLine($"  MP: {heroMP}");
            }

        }
    }
}
