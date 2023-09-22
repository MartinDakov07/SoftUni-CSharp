using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _07._Andrey_and_Billiard
{
    internal class Program
    {
        class Customer
        {
            public Customer(string name)
            {
                Name = name;
                ShopList = new Dictionary<string, int>();
            }
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();            
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] productArg = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string product = productArg[0];
                decimal price = decimal.Parse(productArg[1]);
                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }
                products[product] = price;
            }
            List<Customer> customers = new List<Customer>();
            string command;
            while((command = Console.ReadLine()) != "end of clients")
            {
                string[] commandArg = command.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = commandArg[0];
                string product = commandArg[1];
                int quantity = int.Parse(commandArg[2]);

                if ((products.Any(p => p.Key == product)) == false)
                {
                    continue;
                }
                Customer customer = customers.FirstOrDefault(c => c.Name == name);

                if (customer == null)
                {
                    Customer newCustomer = new Customer(name);
                    newCustomer.ShopList.Add(product, quantity);
                    customers.Add(newCustomer);
                }
                else
                {
                    if (!customer.ShopList.ContainsKey(product))
                    {
                        customer.ShopList.Add(product, quantity);
                    }

                    else
                    {
                        customer.ShopList[product] += quantity;
                    }
                }
            }
            foreach(Customer customer in customers)
            {
                decimal bill = 0;
                foreach(var item in customer.ShopList)
                {
                    bill += item.Value * products[item.Key];                
                }
                customer.Bill = bill;
            }
            decimal totalBill = 0;
            foreach(Customer customer in customers.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{customer.Name}");
                foreach(var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
