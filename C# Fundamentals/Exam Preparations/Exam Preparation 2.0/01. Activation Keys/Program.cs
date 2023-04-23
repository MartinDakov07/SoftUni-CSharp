using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();
            while(command != "Generate")
            {
                string[] commandArg = command.Split(">>>");
                string commandType = commandArg[0];
                if(commandType == "Contains")
                {
                    ContainCommand(commandArg, input);
                }
                else if(commandType == "Flip")
                {
                    FlipCommand(commandArg, input);
                }
                else if (commandType == "Slice")
                {
                    SliceCommand(commandArg, input);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
            
        }
        static void ContainCommand(string[] commandArg, StringBuilder input)
        {
            string substring = commandArg[1];
            if (input.ToString().Contains(substring))
            {
                Console.WriteLine($"{input} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
        static void FlipCommand(string[] commandArg, StringBuilder input)
        {
            string upperOrLower = commandArg[1];
            int startIndex = int.Parse(commandArg[2]);
            int endIndex = int.Parse(commandArg[3]);
            string subString = input.ToString().Substring(startIndex, endIndex - startIndex);
            if (upperOrLower == "Upper")
            {
                subString = subString.ToUpper();
            }
            else if (upperOrLower == "Lower")
            {
                subString = subString.ToLower();
            }
            input.Remove(startIndex, endIndex - startIndex);
            input.Insert(startIndex, subString);
            Console.WriteLine(input);
        }
        static void SliceCommand(string[] commandArg, StringBuilder input)
        {
            int startIndex = int.Parse(commandArg[1]);
            int endIndex = int.Parse(commandArg[2]);
            input.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(input);
        }
    }  
}
