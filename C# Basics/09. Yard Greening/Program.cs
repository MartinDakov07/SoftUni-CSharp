using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metersForPaint = double.Parse(Console.ReadLine());
            double priceForPaint = metersForPaint * 7.61;
            double sale = priceForPaint * 0.18;
            double finalPrice = priceForPaint - sale;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {sale} lv.");
        }
    }
}
