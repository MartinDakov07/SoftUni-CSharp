using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            
            object delimiter = Console.ReadLine();
            
            Console.WriteLine($"{firstName}{delimiter}{lastName}");
            //int chNum = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Character of ur num is: {(char)chNum}");
        }
    }
}
