using System;

namespace _13._Vowel_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine().ToLower();
            try
            {
                int digit = int.Parse(symbol);
                Console.WriteLine("digit");
                return;
            }
            catch
            {
                if(symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u" || symbol == "y")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }                
                return;
            }
            
        }
    }
}
