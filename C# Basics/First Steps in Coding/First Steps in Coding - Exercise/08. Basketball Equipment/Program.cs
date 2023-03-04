using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum for one year
            double priceForOneYear = double.Parse(Console.ReadLine());
            // Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            double priceBasketballTrousers = priceForOneYear - priceForOneYear * 0.4;
            // Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            double priceForSuit = priceBasketballTrousers - priceBasketballTrousers * 0.2;

            //  Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            double priceForBasketBall = priceForSuit / 4;


            // Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
            double priceForAccesories = priceForBasketBall / 5;




            //Sum for every component
            double totalPrice = priceForOneYear + priceBasketballTrousers + priceForSuit + priceForBasketBall + priceForAccesories;
            Console.WriteLine(totalPrice);
            
            

            
        


        }
    }
}
