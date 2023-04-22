using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commandArg = Console.ReadLine().Split(":|:");
            while(commandArg[0] != "Reveal")
            {
                string commandType = commandArg[0];
                if(commandType == "InsertSpace")
                {
                    int index = int.Parse(commandArg[1]);
                    input = input.Insert(index, " ");
                    Console.WriteLine(input);
                }
                else if(commandType == "Reverse")
                {
                    string subString = commandArg[1];
                    int startIndex = input.IndexOf(subString);
                    if (startIndex != -1)
                    {
                        input = input.Remove(startIndex, subString.Length);
                        input += string.Join("",subString.Reverse());
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");                        
                    }
                }
                else if(commandType == "ChangeAll")
                {
                    string subString = commandArg[1];
                    string replacement = commandArg[2];
                    input = input.Replace(subString, replacement);
                    Console.WriteLine(input);
                }
                
                commandArg = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
