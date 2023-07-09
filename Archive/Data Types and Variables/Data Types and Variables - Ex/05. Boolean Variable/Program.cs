using System;

namespace _05._Boolean_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();
            bool convert = Convert.ToBoolean(choice);
            if(convert == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
