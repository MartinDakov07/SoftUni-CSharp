using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //   Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]

         //Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
         
         //Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]

         //Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]

         //Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberryPrice / 2;
            double orangesPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;
            // Sum for every product
            double strawberrySum = strawberryPrice * strawberriesInKg;
            double bananasSum = bananasPrice * bananasInKg;
            double raspberriesSum = raspberriesPrice * raspberriesInKg;
            double orangesSum = orangesPrice * orangesInKg;
            // Total Price
            double totalPrice = strawberrySum + bananasSum + raspberriesSum + orangesSum;
            Console.WriteLine(totalPrice);
        }
    }
}
