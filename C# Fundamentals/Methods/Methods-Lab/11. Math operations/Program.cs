using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Operations(a,b,@operator);
            Console.WriteLine(result);
        }
          private static double Operations(int a,int b,string @operator)
          {
            
            double result = 0;
            if(@operator == "/")
            {
                result = a / b;
            }
            else if(@operator == "-")
            {
                result = a - b;
            }
            else if(@operator == "*")
            {
                result = a * b;
            }
            else if(@operator == "+")
            {
                result = a + b;
            }
            return result;
          }
    }
}
