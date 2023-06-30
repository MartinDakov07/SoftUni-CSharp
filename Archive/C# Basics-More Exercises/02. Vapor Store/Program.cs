using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace _02._Vapor_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double totalSpent = 0;
            BuyGames(game, totalPrice, totalSpent);
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${totalPrice:f2}");
        }
        static void BuyGames(string game, double totalPrice, double totalSpent)
        {
            while (game != "Game Time")
            {

                if (game == "OutFall 4")
                {

                    if (totalPrice - 39.99 >= 0)
                    {
                        totalPrice -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {

                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }

                }
                else if (game == "CS: OG")
                {

                    if (totalPrice - 15.99 >= 0)
                    {
                        totalPrice -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }

                }
                else if (game == "Zplinter Zell")
                {

                    if (totalPrice - 19.99 >= 0)
                    {
                        totalPrice -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }

                }
                else if (game == "Honored 2")
                {

                    if (totalPrice - 59.99 >= 0)
                    {
                        totalPrice -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }

                }
                else if (game == "RoverWatch")
                {

                    if (totalPrice - 29.99 >= 0)
                    {
                        totalPrice -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }

                }
                else if (game == "RoverWatch Origins Edition")
                {

                    if (totalPrice - 39.99 >= 0)
                    {
                        totalPrice -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (totalPrice <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
        }
    }
}
