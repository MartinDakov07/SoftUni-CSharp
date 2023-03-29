using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if(command == "add")
            {
                AddCommand(num1, num2);
            }
            else if(command == "subtract")
            {
                 SubtractCommand(num1, num2);
            }
            else if(command == "multiply")
            {
                MiltiplyCommand(num1, num2);
            }
            else if(command == "divide")
            {
                DivideCommand(num1, num2);
            }
        }
        static void AddCommand(int num1, int num2)
        {
            Console.WriteLine($"{num1+num2}");
        }
        static void SubtractCommand(int num1, int num2)
        {
            Console.WriteLine(num1-num2);
        }
        static void MiltiplyCommand(int num1, int num2)
        {
            Console.WriteLine(num1*num2);
        }
        static void DivideCommand(int num1, int num2)
        {
            Console.WriteLine(num1/num2);
        }
    }
}
