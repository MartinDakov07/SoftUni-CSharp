using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace _03._Unicode_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach(var letter in text)
            {
                Console.Write("\\u" + ((int)letter).ToString("x4"));
            }
        }
    }
}
