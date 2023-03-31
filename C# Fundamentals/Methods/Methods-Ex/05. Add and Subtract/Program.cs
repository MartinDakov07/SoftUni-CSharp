using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = ResultAfterSubtract(thirdNum, firstNum, secondNum);
            Console.WriteLine(result);

        }
        static int SumOfFirstTwoNums(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static int ResultAfterSubtract(int thirdNum,int firstNum, int secondNum)
        {
            int firstAction = SumOfFirstTwoNums(firstNum, secondNum);
            int secondAction = firstAction - thirdNum;
            return secondAction;
        }
    }
}
