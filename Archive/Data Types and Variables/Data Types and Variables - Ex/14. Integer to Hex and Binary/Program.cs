using System;
using System.Buffers.Text;
using System.Linq;

namespace _14._Integer_to_Hex_and_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var hexadecimal = Convert.ToString(num, 16).ToUpper();
            int i;
            int[] binary = new int[10];
            for (i = 0; num > 0;i++)
            {
                binary[i] = num % 2;
                num = num / 2;                
            }            
            Console.WriteLine(hexadecimal);
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
            
            
        }
    }
}
