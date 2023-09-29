using System;
using System.Linq;

namespace _01._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            char[] messageToChar = message.ToCharArray();
            Array.Reverse(messageToChar);
            string reversed = new string(messageToChar);
            Console.WriteLine(reversed);
        }
    }
}
