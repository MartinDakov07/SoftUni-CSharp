using System;

namespace C__Conditional_Statements_and_Loops___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if(grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
