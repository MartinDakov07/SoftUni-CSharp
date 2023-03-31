using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char result =(char) ReturnAllSymbolsInRange(start, end);
            
        }
        static char ReturnAllSymbolsInRange(char start, char end)
        {
            int sumOfChar = (int)start;
            int sumOtherChar = (int)end;
            if(sumOfChar < sumOtherChar)
            {
                for (int i = sumOfChar+1; i <= sumOtherChar-1; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            else if(sumOfChar > sumOtherChar)
            {
                start = (char)sumOtherChar;
                end = (char)sumOfChar;
                for (int i = start + 1; i <= end - 1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            
            return end;
            
            
           
        }
    }
}
