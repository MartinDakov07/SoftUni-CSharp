using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double stawberriesKg = double.Parse(Console.ReadLine());                               
            double raspberriesPrice = strawberriesPrice / 2;
            double orangePrice = raspberriesPrice - (raspberriesPrice * 0.4);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);
            double strawberriesTotal = strawberriesPrice * stawberriesKg;
            double raspberriesTotal = raspberriesKg * raspberriesPrice;
            double orangeTotal = orangeKg * orangePrice;
            double bananasTotal = bananasPrice * bananasKg;
            double totalPrice = strawberriesTotal + raspberriesTotal + orangeTotal + bananasTotal;
            Console.WriteLine($"{totalPrice:f2}");






        }
    }
}
