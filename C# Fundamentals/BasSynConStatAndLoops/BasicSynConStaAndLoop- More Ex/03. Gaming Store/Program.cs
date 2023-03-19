using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());            
            string game = Console.ReadLine();
            double totalSpent = balance;
            while(game != "Game Time")
            {
                double price = 0;
                if(game == "OutFall 4")
                {
                    price = 39.99;
                    
                    if(price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if(game == "CS: OG")
                {
                    price = 15.99;
                    
                    if (price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if(game == "Zplinter Zell")
                {
                    price = 19.99;
                    
                    if (price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                    
                    if (price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;                    
                    if (price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    
                    if (price <= balance)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if(balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent- balance:f2}. Remaining: ${balance:f2}");
        }
    }
}
