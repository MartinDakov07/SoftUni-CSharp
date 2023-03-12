using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for(int counter = 0; counter < countOfInputs;counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;  
                }
                

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
