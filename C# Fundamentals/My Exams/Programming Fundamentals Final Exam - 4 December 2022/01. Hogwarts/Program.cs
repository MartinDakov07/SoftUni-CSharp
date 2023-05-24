using System;
using System.Text;
namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();           
            string command = Console.ReadLine();
            while(command != "Abracadabra")
            {
                string[] commandArg = command.Split(' ');
                string commandType = commandArg[0];
                if(commandType == "Abjuration")
                {
                    spell = Abjuration(spell, commandArg, commandType);
                    Console.WriteLine(spell);
                }
                else if(commandType == "Necromancy")
                {
                    spell = Necromancy(spell, commandArg, commandType);
                    Console.WriteLine(spell);
                }
                else if(commandType == "Illusion")
                {
                    int index = int.Parse(commandArg[1]);
                    string letter = commandArg[2];
                    
                    if (index >= 0 && index < spell.Length)
                    {
                        //spell = spell.Remove(index, 1);
                        //spell = spell.Insert(index, letter);
                        spell = Illusion(spell, commandArg, commandType);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if(commandType == "Divination")
                {
                    //string firstSubStr = commandArg[1];
                    //string secondSubStr = commandArg[2];
                    //
                    //if (spell.Contains(firstSubStr))
                    //{
                    //    spell = spell.Replace(firstSubStr, secondSubStr);
                    //}
                    spell = Divination(spell, commandArg, commandType);
                    Console.WriteLine(spell);
                }
                else if(commandType == "Alteration")
                {
                    //string subString = commandArg[1];
                    //
                    //if (spell.ToString().Contains(subString))
                    //{
                    //    int indexOf = spell.IndexOf(subString);
                    //    spell = spell.Remove(indexOf, subString.Length);
                    //
                    //}
                    spell = Alteration(spell, commandArg, commandType);
                    Console.WriteLine(spell);
                }
                else
                {
                    Console.WriteLine("The spell did not work");
                }
                command = Console.ReadLine();
            }
        }
        static string Abjuration(string spell,string[] commandArg, string commandType)
        {
            spell = spell.ToUpper();     
            return spell;
        }
        static string Necromancy(string spell, string[] commandArg, string commandType)
        {
            spell = spell.ToLower();
            return spell;
        }
        static string Illusion(string spell, string[] commandArg, string commandType)
        {
            int index = int.Parse(commandArg[1]);
            string letter = commandArg[2];            
            if (index >= 0 && index < spell.Length)
            {
                spell = spell.Remove(index, 1);
                spell = spell.Insert(index, letter);                
            }
            
            return spell;

            //return "The spell was too weak";

        }
        static string Divination(string spell, string[] commandArg, string commandType)
        {
            string firstSubStr = commandArg[1];
            string secondSubStr = commandArg[2];           
            if (spell.Contains(firstSubStr))
            {
                spell = spell.Replace(firstSubStr, secondSubStr);                
            }
            return spell;           
        }
        static string Alteration(string spell, string[] commandArg, string commandType)
        {
            string subString = commandArg[1];           
            if (spell.ToString().Contains(subString))
            {
                int indexOf = spell.IndexOf(subString);
                spell =spell.Remove(indexOf, subString.Length-1);
                
            }
            return spell;
        }
    }
}
