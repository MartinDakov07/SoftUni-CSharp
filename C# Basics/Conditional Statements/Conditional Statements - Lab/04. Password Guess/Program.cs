using System;

namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordFromTheUser = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (passwordFromTheUser == password) 
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
