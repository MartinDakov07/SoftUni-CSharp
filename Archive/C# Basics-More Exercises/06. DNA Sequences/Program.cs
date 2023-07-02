using System;
using System.Runtime.InteropServices;

namespace _06._DNA_Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] comb = new string[] { "A", "C", "G", "T" };
            string[] sequences = new string[64];
            int index = 0;
            //With this loop we keep all of our sequences in one array (it will always has a length of 64)
            // if i=0 -> A and it increases +1, so i =1 => C etc       
            // if j=0 -> A and it increases +1, so j =1 => C etc
            // if k=0 -> A and it increases +1, so k =1 => C etc
            //Once it starts from k it will go through the whole k loop
            //Then it will go through j +1 and go through next k loop
            //And once both are done (j and k) it will go on i loop
            //And this happens n-times
            for (int i = 0; i < comb.Length; i++)
            {
                for (int j = 0; j < comb.Length; j++)
                {
                    for (int k = 0; k < comb.Length; k++)
                    {
                        string sequence = comb[i] + comb[j] + comb[k];             
                        sequences[index++] = sequence;                                                                                                                                                             
                    }
                }
            }
            //Go through every sequence and calculate each sum
            for(int i = 0; i < sequences.Length; i++)
            {
                string sequence = sequences[i];
                double seqSum = 0;

                foreach(char c in sequence)
                {
                    if(c == 'A')
                    {
                        seqSum += 1;
                    }
                    else if(c == 'C')
                    {
                        seqSum += 2;
                    }
                    else if(c == 'G')
                    {
                        seqSum += 3;
                    }
                    else if(c == 'T')
                    {
                        seqSum += 4;
                    }
                }

                if(seqSum >= sum)
                {
                    //if its more or equal than our given sum print the sequence with O before and after it
                    Console.Write($"O{sequence}O ");
                }
                else
                {
                    //If its less than our given sum print the sequnce with X before and after it
                    Console.Write($"X{sequence}X ");
                }
                //if we have fourth sequence => go on the next line
                //i+1 because we start from 0, so that means it will go on the next line at the start
                if((i+1) % 4 == 0)
                {

                    //Go on next line
                    Console.WriteLine();
                }
            }
        }
    }
}
