using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currentNum = 1;
            bool isBigger = false;
            for(int rows = 1; rows <= num; rows++)
            {
                for(int cols = 1; cols <= rows; cols++)
                {
                    if(currentNum > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
