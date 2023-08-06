using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            //strings.Reverse(); why is this not working, i have no idea - i will go check it in google :)
            //Lets try the other way
            string lastString = strings[strings.Length - 1];
            int count = 0;
            string[] reversedString = new string[strings.Length];
            for(int i = strings.Length-1;i >= 0; i--)
            {
                reversedString[count++] = strings[i];
            }
            Console.WriteLine(string.Join(" ",reversedString));
        }
    }
}
