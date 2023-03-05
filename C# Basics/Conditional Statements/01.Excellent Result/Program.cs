using System;

namespace ConditionalStatementsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentScore = double.Parse(Console.ReadLine());
            bool isExelletnScore = currentScore >= 5.5;
            if (isExelletnScore) 
            {
                Console.WriteLine("Excellent!");
            }
        }
       
    }
}
