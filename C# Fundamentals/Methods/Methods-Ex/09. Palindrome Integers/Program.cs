using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            IsNumPalinDrome(command);
        }
        static void IsNumPalinDrome(string command)
        {
            
            while(command != "END")
            {
                int currNum = int.Parse(command);
                int numCopy = currNum;
                
                int result = 0;
                while(numCopy > 0)
                {
                    result = result * 10 + numCopy % 10;
                    numCopy /= 10;
                }
                if(currNum == result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                command = Console.ReadLine();
                
            }
        }
    }
}
