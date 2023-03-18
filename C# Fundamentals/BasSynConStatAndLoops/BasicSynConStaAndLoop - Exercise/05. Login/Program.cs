using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;
            for(int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }
            int failedTries = 0;
            string enteredPassword = Console.ReadLine();
            while (enteredPassword != password)
            {
                if(failedTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                enteredPassword = Console.ReadLine();
            }
            if(failedTries < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
