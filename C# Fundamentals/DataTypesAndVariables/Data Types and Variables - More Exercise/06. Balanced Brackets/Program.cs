using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            bool openedBracket = false;
            for(int i = 0; i < n; i++)
            {
                string randomString = Console.ReadLine();
                if(randomString == "(")
                {                                       
                    if (openedBracket)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        openedBracket = true;
                    }                  
                }
                else if(randomString == ")")
                {
                    if (openedBracket)
                    {
                        openedBracket = false;                       
                    }
                    else
                    {
                        isBalanced = false;
                    }                  
                }
            }
            if(openedBracket) isBalanced = false;
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
