using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = cmdArg[0];
                int startIndex = int.Parse(cmdArg[1]);
                int endIndex = int.Parse(cmdArg[2]);
                string mergedMessage = "";
                if (startIndex < 0 || startIndex >= input.Count)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }
                if (type == "merge")
                {

                    for(int i = startIndex; i <= endIndex; i++)
                    {
                        mergedMessage += input[i];
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, mergedMessage);
                    
                }
                else if (type == "divide")
                {
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);
                    List<string> dividedList = new List<string>();
                    string word = input[index];
                    input.RemoveAt(index);
                    int parts = word.Length / partitions;
                    for(int i = 0; i < partitions; i++)
                    {
                        if(i == partitions - 1)
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    input.InsertRange(index, dividedList);
                }                
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
