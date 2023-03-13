using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string currentPassword = Console.ReadLine();
            string inputPassword = Console.ReadLine();
            while(inputPassword != currentPassword)
            {
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
