using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Text;
namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read from the console the number of messages we will get
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[^\@\-\!\:\>]*?\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?:(?<population>\d+)[^\@\-\!\:\>]*?!(?<attackType>A|D)![^\@\-\!\:\>]*?\-\>(?<soldierCount>\d+)[^\@\-\!\:\>]*?";
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                message = GetDecrypt(message);
                Match match = Regex.Match(message, pattern);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;
                    if(attackType == "A")
                    {
                        attackedPlanets = AttackedPlanet(planet,attackedPlanets);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlanets = DestroyedPlanets(planet, destroyedPlanets);
                    }
                }
            }
            PrintResult(attackedPlanets, destroyedPlanets);
        }
        static string GetDecrypt(string message)
        {
            int count = 0;
            foreach(var c in message.ToLower())
            {
                if(c == 's' || c =='t' || c == 'a' || c == 'r')
                {
                    count++;
                }
            }
            StringBuilder decryptedMessage = new StringBuilder();
            foreach(char c in message)
            {
                decryptedMessage.Append((char)(c - count));
            }
            return decryptedMessage.ToString();
        }   
        static List<string> AttackedPlanet(string planet,List<string> attackedPlanets)
        {
            attackedPlanets.Add(planet);
            return attackedPlanets;
        }
        static List<string> DestroyedPlanets(string planet, List<string> destroyedPlanets)
        {
            destroyedPlanets.Add(planet);
            return destroyedPlanets;
        }
        static void PrintResult(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach(var planet in destroyedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
