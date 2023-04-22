using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> composers = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composerAndKey = $"{input[1]}:{input[2]}";
                if (!composers.ContainsKey(piece))
                {
                    composers.Add(piece, composerAndKey);
                }                
            }
            string command = Console.ReadLine();
            while(command != "Stop")
            {
                string[] commandArg = command.Split("|");
                string commandType = commandArg[0];
                
                if(commandType == "Add")
                {
                    string piece = commandArg[1];
                    string composer = commandArg[2];
                    string key = commandArg[3];
                    if (!composers.ContainsKey(piece))
                    {

                        composers.Add(piece,$"{composer}:{key}");
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if(commandType == "Remove")
                {
                    string piece = commandArg[1];
                    if (composers.ContainsKey(piece))
                    {
                        composers.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(commandType == "ChangeKey")
                {
                    string piece = commandArg[1];
                    string newKey = commandArg[2];
                    if (composers.ContainsKey(piece))
                    {
                        
                        string[] value = composers[piece].Split(":");
                        value[1] = newKey;
                       composers[piece] = string.Join(":",value);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var composer in composers)
            {
                string[] composerKey = composer.Value.Split(":");
                Console.WriteLine($"{composer.Key} -> Composer: {composerKey[0]}, Key: {composerKey[1]}");
            }
        }
    }
}
