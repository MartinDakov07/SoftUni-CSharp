using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _07._Sales_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] sale = Console.ReadLine().Split(" ").ToArray();
                string town = sale[0];
                string product = sale[1];
                decimal price = decimal.Parse(sale[2]);
                decimal quantity = decimal.Parse(sale[3]);
                decimal totalPrice = price * quantity;
                if (!salesByTown.ContainsKey(town))
                {
                    salesByTown[town] = 0;
                }
                salesByTown[town] += totalPrice;
            }
            foreach(var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }
        
    }
}
