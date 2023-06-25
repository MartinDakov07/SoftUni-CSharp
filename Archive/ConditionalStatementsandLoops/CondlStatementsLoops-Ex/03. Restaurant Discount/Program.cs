using System;

namespace _03._Restaurant_Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            if(groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
                if(package == "Normal")
                {
                    price += 500;
                    price = price - price * 0.05;
                }
                else if(package == "Gold")
                {
                    price += 750;
                    price = price - price * 0.1;
                }
                else if(package == "Platinum")
                {
                    price += 1000;
                    price = price - price * 0.15;
                }
                
            }
            else if (groupSize >= 51 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
                 if (package == "Normal")
                 {
                     price += 500;
                     price = price - price * 0.05;
                 }
                 else if (package == "Gold")
                 {
                     price += 750;
                     price = price - price * 0.1;
                 }
                 else if (package == "Platinum")
                 {
                     price += 1000;
                     price = price - price * 0.15;
                 }

            }
            else if (groupSize >= 101 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
                if (package == "Normal")
                {
                    price += 500;
                    price = price - price * 0.05;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    price = price - price * 0.1;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    price = price - price * 0.15;
                }

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            price /= groupSize;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price:f2}$");
        }
    }
}
