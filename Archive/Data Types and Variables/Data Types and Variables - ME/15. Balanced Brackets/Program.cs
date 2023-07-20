using System;

namespace _15._Balanced_Brackets
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
                string bracket = Console.ReadLine();
                if(bracket == "(")
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
                else if(bracket == ")")
                {

                    if (!openedBracket)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        openedBracket = false;
                    }                    
                }
            }
            if (openedBracket)
            {
                isBalanced = false;
            }
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
