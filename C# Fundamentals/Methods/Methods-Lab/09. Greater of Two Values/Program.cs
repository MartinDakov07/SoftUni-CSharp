using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if(value == "int")
            {
                int firstNum = int.Parse(firstValue);
                int secondNum = int.Parse(secondValue);
                int result = GetMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if(value == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if(value == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }
        private static int GetMax(int a, int b)
        {
            
            if(a > b)
            {
                return a;
            }
           
            
                return b;
            
        }
        static string GetMax (string a,string b)
        {
            int result = a.CompareTo(b);
            if(result > 0)
            {
                return a;
            }
            return b;
            //int sumA = 0;
            //int sumB = 0;
            //for(int i = 0; i < firstString.Length; i++)
            //{
            //    sumA += firstString[i];
            //}
            //for(int j = 0; j < secondString.Length; j++)
            //{
            //    sumB += secondString[j];
            //}
            
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
           
            
                return b;
            
        }

    }
}
