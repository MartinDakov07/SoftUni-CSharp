using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stops = Console.ReadLine().Split(' '); 
           // List<string> stops = Console.ReadLine().Split(' ').ToList();
            string stops = Console.ReadLine();
            string command = Console.ReadLine();
            while(command != "Travel")
            {
                string[] commandArg = command.Split(":");                
                string commandType = commandArg[0];
                if(commandType == "Add Stop")
                {
                    int index = int.Parse(commandArg[1]);
                    string insertString = commandArg[2];
                    if(index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, insertString);
                    }
                    Console.WriteLine(String.Join("",stops));
                }
                else if(commandType == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    
                    if (startIndex >= 0 && startIndex < stops.Length)
                    {
                        if(endIndex >= 0 && endIndex < stops.Length)
                        {
                            stops = stops.Remove(startIndex, endIndex-(startIndex-1));
                        }
                    }                    
                    Console.WriteLine(String.Join("", stops));
                }
                else if(commandType == "Switch")
                {
                    string oldString = commandArg[1];
                    string newString = commandArg[2];
                    if (stops.Contains(oldString))
                    {
                         int indexOfString = stops.IndexOf(oldString);
                       stops = stops.Replace(oldString, newString);
                        
                    }
                    Console.WriteLine(String.Join("", stops));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {string.Join("",stops)}");
        }
    }
}
