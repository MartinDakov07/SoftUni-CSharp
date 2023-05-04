using System;

namespace _03._Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string typeOfDocument = Console.ReadLine();
            string yesOrNo = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0;

            if(years == "one")
            {
                if(typeOfDocument == "Small")
                {
                    price = 9.98;
                }
                if(typeOfDocument == "Middle")
                {
                    price = 18.99;
                }
                if(typeOfDocument == "Large")
                {
                    price = 25.98;

                }
                if(typeOfDocument == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            else if (years == "two")
            {
                if (typeOfDocument == "Small")
                {
                    price = 8.58;
                }
                if (typeOfDocument == "Middle")
                {
                    price = 17.09;
                }
                if (typeOfDocument == "Large")
                {
                    price = 23.59;

                }
                if (typeOfDocument == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if(yesOrNo == "yes")
            {
                if(years == "one")
                {
                    if (price <= 10)
                    {
                        price += 5.50;
                    }
                    else if (price <= 30)
                    {
                        price += 4.35;
                    }
                    else
                    {
                        price += 3.85;
                    }
                }
                else if (years == "two")
                {
                    if (price <= 10)
                    {
                        price += 5.50;
                    }
                    else if (price <= 30)
                    {
                        price += 4.35;
                    }
                    else
                    {
                        price += 3.85;
                    }
                    price = price - price * 0.0375;
                }
            }
            else if (yesOrNo == "no")
            {
                price = price - price * 0.0375;
            }
            double totalPrice = price * months;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
