using System;
namespace _11._String_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string message = null;
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
            
                if (evenOrOdd == "odd")
                {
                    if (i % 2 != 0)
                    {
                        message = message + word + delimeter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        message = message + word + delimeter;
                    }
                }
            }
            
            if (message.EndsWith(delimeter.ToString()))
            {
                message = message.Remove(message.Length - 1);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine(message);
            }
            
            
           

        }        
    }
}
