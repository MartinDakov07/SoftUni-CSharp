using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;  
            for (int counter = 0; counter < 2* countOfInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(counter < countOfInputs)
                {
                    leftSum += currentNumber;
                }
                else
                {
                    rightSum += currentNumber;
                }
                        
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
