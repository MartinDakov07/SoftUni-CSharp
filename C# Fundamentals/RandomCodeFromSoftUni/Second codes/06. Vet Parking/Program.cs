using System;

namespace _06._Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            for(int i = 1; i <=days; i++)
            {
                price = 0;
                for(int j = 1; j <=hours; j++)
                {
                    if (i % 2 == 0)
                    {
                        if(j % 2 == 0)
                        {
                            price += 1;
                        }
                        else
                        {
                            price += 2.50;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            price += 1.25;
                        }
                        else
                        {
                            price += 1; ;
                        }
                    }
                   
                }
                Console.WriteLine($"Day: {i} - {price:f2} leva");
                totalPrice += price;
            }
            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
