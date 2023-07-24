using System;

namespace _08._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int better = GetMaxInt(first, second);
                Console.WriteLine(better);
            }
            else if(type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char better = GetMaxChar(first, second);
                Console.WriteLine(better);
            }
            else if(type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string better = GetBetterString(first, second);
                Console.WriteLine(better);
            }

        }
        static int GetMaxInt(int first, int second)
        {
            return first > second ? first : second;
        }
        static char GetMaxChar(char first, char second)
        {
            return first > second ? first : second;
        }
        static string GetBetterString(string first, string second) 
        {
            int num = first.CompareTo(second);
            if(num > 0)
            {
                return first;
            }
            return second;
        }
    }
}
