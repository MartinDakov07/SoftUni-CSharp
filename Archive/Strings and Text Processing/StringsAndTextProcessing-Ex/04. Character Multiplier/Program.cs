using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _04._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];
            long result = 0;
            if (firstWord.Length == secondWord.Length)
            {                
                for(int i = 0; i < firstWord.Length; i++)
                {
                    int firstValue = (int)firstWord[i];
                    int secondValue = (int)secondWord[i];
                    result += firstValue * secondValue;
                }
            }
            else
            {
                int lowerLength = Math.Min(firstWord.Length, secondWord.Length);
                
                if(firstWord.Length > secondWord.Length)
                {                   
                    for(int i = 0; i < lowerLength; i++)
                    {
                        int firstValue = (int)firstWord[i];
                        int secondValue = (int)secondWord[i];
                        result += firstValue * secondValue;
                    }
                    for(int i = lowerLength; i < firstWord.Length; i++)
                    {
                        result += (int)firstWord[i];
                    }
                }
                else
                {
                    for (int i = 0; i < lowerLength; i++)
                    {
                        int firstValue = (int)firstWord[i];
                        int secondValue = (int)secondWord[i];
                        result += firstValue * secondValue;
                    }
                    for (int i = lowerLength; i < secondWord.Length; i++)
                    {
                        result += (int)secondWord[i];
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
