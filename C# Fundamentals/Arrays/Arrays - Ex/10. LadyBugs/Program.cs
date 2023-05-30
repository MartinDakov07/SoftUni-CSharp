using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Net.Http.Headers;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];

            int[] initialIndexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach(int index in initialIndexes)
            {
                if(index>=0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(cmdArg[0]);
                string direction = cmdArg[1];
                int fliyingLength = int.Parse(cmdArg[2]);
                
                //Check if ladybug is inside the field!
                if(ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    //Invalid index -> Nothing happens
                    continue;
                }
                if (field[ladybugIndex] == 0)
                {
                    //There is no ladybug there
                    continue;
                }
                //Here out ladybug goes in the air-she is no more on her spot
                field[ladybugIndex] = 0;

                //if its on the left we have to make our length negative(so we can go back)
                if(direction == "left")
                {
                    fliyingLength *= -1;
                }

                //This loop is going to loop until our ladybug find new place(or leave it)
                // where to go    startIndex      length
                int nextIndex = ladybugIndex + fliyingLength;
                //In this while loop we check:
                //if the index is below 0, so that means its outside our field
                //if our next index is equal or bigger than our field length, then it is gone
                //if on our index there is a ladybug-skip it. Otherwise land on it :)
                while(nextIndex >=0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += fliyingLength;
                }

                //This checks if our index is available-if its not then we wont put our ladybug on the field
                //That's why we use the continue(so we cant reach our next spot)
                if(nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }
                //The ladybug found new place!
                field[nextIndex] = 1;
            }
            Console.WriteLine(String.Join(" ",field));
        }
    }
}
