using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            string personInput = Console.ReadLine();
            while (personInput != "END")
            {
                string[] personArgs = personInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                char command = char.Parse(personArgs[0]);
                string name = personArgs[1];               
                if(command == 'A')
                {
                    string phoneNumber = personArgs[2];
                    if (!numbers.ContainsKey(name))
                    {
                        numbers.Add(name, "");
                    }
                    numbers[name] = phoneNumber;
                }
                else if(command == 'S')
                {
                    if (numbers.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {numbers[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                personInput = Console.ReadLine();
            }
        }
    }
}
