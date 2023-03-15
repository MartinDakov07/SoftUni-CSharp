using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberFromUser = int.Parse(Console.ReadLine());
            int combination = 0;
            for (int firstNumber = 0; firstNumber <= numberFromUser; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= numberFromUser; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= numberFromUser; thirdNumber++)
                    {
                        if (firstNumber + secondNumber + thirdNumber == numberFromUser)
                        {
                            combination++;
                        }                     
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}
