﻿using System;
using System.Linq;

namespace _03._Safe_Manipulation
{
    internal class Program
    {        
        public static int maxIndex;
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();
            maxIndex = elements.Length;
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] commandArg = command.Split();
                switch (commandArg[0])
                {
                    case "Reverse":
                        elements = Reverse(elements, maxIndex);
                        break;
                    case "Distinct":
                        elements = Distinct(elements, maxIndex);
                        break;
                    case "Replace":
                        string[] replace = command.Split(' ').ToArray();
                        int index = int.Parse(replace[1]);
                        string replaceMes = replace[2];
                        if(index < 0 || index > elements.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            elements[index] = replaceMes;
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                command = Console.ReadLine();
            }
            Print(elements, maxIndex);

        }
        static string[] Reverse(string[] arr, int maxInd)
        {
            string[] reversed = new string[maxInd];
            int index = 0;
            for (int i = maxInd - 1; i >= 0; i--)
            {
                reversed[index] = arr[i];
                index++;
            }
            return reversed;
        }
        static string[] Distinct(string[] arr, int maxInd)
        {
            string[] distincted = new string[maxInd];
            int index = 0;
            for (int i = 0; i < maxInd; i++)
            {
                string curr = arr[i];//the word that should be unique
                if (curr == "z") continue;//if the word is almost deleted, skip this step
                for (int j = 0; j < maxInd; j++)//What this for loop is doing, is that it checks through all words, and if we see the same word, we write 'z', to mark it as non-unique
                                                //if this loop didnt exist we were going to print all the non unique word to our new array
                {
                    if (arr[j] == curr)
                    {
                        arr[j] = "z";//mark as skippable word
                    }
                }
                distincted[index] = curr;//add the word to our new array
                index++;
            }
            maxIndex = index;//if we have deleted words, we should decrease the length
            return distincted;
        }
        static void Print(string[] arr, int maxInd)
        {
            for (int i = 0; i < maxInd - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[maxInd - 1]);
        }
    }
}

