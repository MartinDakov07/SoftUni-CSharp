using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;
using System.IO;
using static _05._Nether_Realms.Program;
using System.Xml.Linq;

namespace _05._Nether_Realms
{
    internal class Program
    {
        public class Demon
        {
            public string Name { get; set; }
            public int Health { get; set;}
            public double Damage { get; set; }

            public Demon(string name)
            {
                this.Name = name;
            }

            public override string ToString()
            
             =>  $"{this.Name} - {this.Health} health, {this.Damage:f2} damage";
            

        }
        static void Main(string[] args)
        {
            //Read from the console all demons
            string[] messages = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);                
            //Add our demons
            List<Demon> demons = new List<Demon>();
            foreach (var name in messages)
            {
                demons.Add(new Demon(name));
            }                     
            //Go for every demon and getting the information about them
            foreach (var demon in demons)
            {                              
                demon.Health = GetHealth(demon.Name);
                demon.Damage = GetDamage(demon.Name) ;
            }
            Console.WriteLine(String.Join(Environment.NewLine,demons.OrderBy(x=>x.Name)));
        }

        static int GetHealth(string demon)
        {
            MatchCollection matchHealth = Regex.Matches(demon, @"[^\d+\-\/*\.]");
            string healthText = String.Join("", matchHealth);
            return healthText.Sum(x => (int)x);
            ////Get all matches
            //string healthPattern = @"(?<health>[^\d+\-\/*\.])";
            //MatchCollection matches = Regex.Matches(demon, healthPattern);
            //int health = 0;
            //string message = "";
            ////Concatenate all matches in one
            //foreach (var match in matches)
            //{
            //    message += match;
            //}
            //// for each symbol in the message we sum their ascii codes
            //foreach(char c in message)
            //{
            //    health += (int)c;
            //}
            //return health;
        }
        static double GetDamage(string demon)
        {
            //get the damage matches
            string damagePattern = @"(?<damage>[-]?\d*[.]?[\d]+)";
            MatchCollection matches = Regex.Matches(demon, damagePattern);
            //First we sum all the matches
            double damage = matches.Select(x => double.Parse(x.Value)).Sum();
            //Get matches for multiply and divide
            MatchCollection multiplyCount = Regex.Matches(demon, @"[*]");
            MatchCollection divideCount = Regex.Matches(demon, @"[\/]");
            //Second, we multiply or divide if we have
            damage *= Math.Pow(2, multiplyCount.Count);
            damage /= Math.Pow(2, divideCount.Count);
            return damage;
        }
    }
}
