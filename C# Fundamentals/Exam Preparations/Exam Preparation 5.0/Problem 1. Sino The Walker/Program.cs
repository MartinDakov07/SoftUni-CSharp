using System;
using System.Linq;
using System.Numerics;
namespace Problem_1._Sino_The_Walker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherSum = int.Parse(Console.ReadLine());
            int ticketsCount = 0;
            int otherProducts = 0;
            
            string product = Console.ReadLine();
            while (product != "End" && voucherSum > 0)
            {
                int ticketPrice = 0;
                if (product.Length > 8)
                {
                    char c = product[0];
                    char b = product[1];
                    ticketPrice = (int)c + (int)b;
                    if(ticketPrice > voucherSum)
                    {
                        break;
                    }
                    voucherSum -= ticketPrice;
                    if(voucherSum >= 0)
                    {
                        ticketsCount++;
                    }
                    
                }
                else
                {
                    char c = product[0];
                    ticketPrice = (int)c;
                    if (ticketPrice > voucherSum)
                    {
                        break;
                    }
                    voucherSum -= ticketPrice;
                    if (voucherSum >= 0)
                    {
                        otherProducts++;
                    }
                       
                }   
                product = Console.ReadLine();
            }
            Console.WriteLine(ticketsCount);
            Console.WriteLine(otherProducts);
        }
    }
}
