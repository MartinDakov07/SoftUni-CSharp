using System;

namespace _03._Pastry_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   С наближаването на коледните и новогодишни празници сладкарница започва записване на
            //   поръчки за изработка на сладкиши,
            //   като предлага следния ценоразпис и отстъпки според
            //   датата на която е направена поръчката. 
            //
            //                      Торта              Суфле              Баклава
            //   До 15 декември    24 лв./ бр.        6.66 лв./ бр.    12.60 лв./ бр.
            //   След 15 декември  28.70 лв./ бр.   9.80 лв./ бр.    16.98 лв./ бр.

            //   До 22 декември включително съществуват следните отстъпки, които се прилагат в следния ред: 
            //  При поръчка от 100 лв.до 200 лв. -> 15 % отстъпка
            //    При поръчка над 200 лв. -> 25 % отстъпка
            //   До 15 декември включително -> 10 % допълнителна отстъпка от крайната цена

                 // От конзолата се четат 3 реда:
                  // 1.Сладкиш - текст - "Cake", "Souffle" или "Baklava"
                 // 2.Брой на поръчаните сладкиши - цяло число в интервала[1 … 10000]
                //  3.Ден от месец декември преди Коледа - цяло число в интервала[1 … 24]


            //На конзолата се отпечатва 1 ред:
            //	Цената, която трябва да се заплати, форматирана до втория знак след десетичната запетая

            string treat = Console.ReadLine();
            int numOfTreats = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            if(day <= 15)
            {
                if(treat == "Cake")
                {
                    price = 24; 
                }
                else if(treat == "Souffle")
                {
                    price = 6.66;
                }
                else
                {
                    price = 12.60;
                }
            }
            else
            {
                if (treat == "Cake")
                {
                    price = 28.70;
                }
                else if (treat == "Souffle")
                {
                    price = 9.80;
                }
                else
                {
                    price = 16.98;
                }
            }
            totalPrice = price * numOfTreats;
            if (day <= 22)
            {
                if (totalPrice >= 100 && totalPrice <= 200)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else if (totalPrice > 200)
                {
                    totalPrice = totalPrice * 0.75;
                }
                else
                {
                    totalPrice = totalPrice;
                }
            }
            
           
            if(day <= 15)
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
