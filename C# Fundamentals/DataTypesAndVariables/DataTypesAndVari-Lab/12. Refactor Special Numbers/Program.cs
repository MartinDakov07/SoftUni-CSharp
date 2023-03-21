using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isSpecialNum = false;
            
            for (int i = 1; i <= num; i++)

            {
                int numCopy = 0;
                int sum = 0;
                numCopy = i;

                while (numCopy > 0)

                {

                    sum += numCopy % 10;

                    numCopy = numCopy / 10;

                }

                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
                               
            }
        }
    }
}
