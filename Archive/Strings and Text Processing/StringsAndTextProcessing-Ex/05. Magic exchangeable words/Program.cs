using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _05._Magic_exchangeable_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];
            bool isExchangable = true;
            Dictionary<char, char> corresponds = new Dictionary<char, char>();

            int lowerLength = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < lowerLength; i++)
            {
                if (!corresponds.ContainsKey(firstWord[i]))
                {
                    if (corresponds.ContainsValue(secondWord[i]))
                    {
                        isExchangable = false;
                    }
                    else
                    {
                        corresponds.Add(firstWord[i], secondWord[i]);
                    }
                }
                else
                {                  
                    if (corresponds[firstWord[i]] != secondWord[i])
                    {
                        isExchangable = false;
                    }
                }
            }                                      
            if(firstWord.Length > secondWord.Length)
            {
                
                for(int i = lowerLength; i < firstWord.Length; i++)
                {
                    if (!corresponds.ContainsKey(firstWord[i]))
                    {
                        isExchangable = false;
                    }
                }
            }
            else if(firstWord.Length < secondWord.Length)
            {                   
                for (int i = lowerLength; i < secondWord.Length; i++)
                {
                    if (!corresponds.ContainsValue(secondWord[i]))
                    {
                        isExchangable = false;
                    }
                }
            }
            
            if (isExchangable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
