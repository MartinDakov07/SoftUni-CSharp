using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int evenNumber = 0;
            int oddNumber = 0; 
            for(int counter = 1; counter <= countOfInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                    evenNumber += currentNumber;
                }
                else if (counter % 2 != 0)
                {
                    oddNumber += currentNumber;
                }
            }
            if (oddNumber == evenNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddNumber - evenNumber)}");
            }
        }
    }
}
