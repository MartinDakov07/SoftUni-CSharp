using System;

namespace _04._Variable_in_Hex_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexaFormat = Console.ReadLine();
            decimal num = Convert.ToInt32(hexaFormat, 16);
            Console.WriteLine(num);
        }
    }
}
