using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfAllEntNumbers = 0;
            while(n > sumOfAllEntNumbers)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumOfAllEntNumbers += inputNumber;
                
            }
            
                Console.WriteLine(sumOfAllEntNumbers);
            
        }
    }
}
