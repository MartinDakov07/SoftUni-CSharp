using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for(int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                int cValue = (int)c;
                int cNewValue = cValue + key;
                char cKey = (char)cNewValue;
                message += cKey;
            }
            Console.WriteLine(message);
        }
    }
}
