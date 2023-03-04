using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depozitSum = double.Parse(Console.ReadLine());
            int termInMonths = int.Parse(Console.ReadLine());
            double lihvenPercent = double.Parse(Console.ReadLine())/100;
            double value = depozitSum + termInMonths * ((depozitSum * lihvenPercent) / 12);
            //   депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            Console.WriteLine(value);
        }
    }
}
