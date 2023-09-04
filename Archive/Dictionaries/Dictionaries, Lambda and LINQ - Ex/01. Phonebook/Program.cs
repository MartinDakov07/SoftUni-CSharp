using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _01._Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string checker = commandArg[0];
                string name = commandArg[1];
                if(checker == "A")
                {
                    string phoneNumber = commandArg[2];
                    if (!phoneNumbers.ContainsKey(name))
                    {
                        phoneNumbers.Add(name, phoneNumber);
                    }
                    else
                    {
                        phoneNumbers[name] = phoneNumber;
                    }
                }
                else if(checker == "S")
                {
                    if (phoneNumbers.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneNumbers[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }                        
                }
                command = Console.ReadLine();
            }
        }
    }
}
