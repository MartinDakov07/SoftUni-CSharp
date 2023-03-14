using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = double.Parse(Console.ReadLine());//3.50 
            changeToReturn *= 100;//350
            int count = 0;//moneti
            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    count++;
                    changeToReturn -= 200;
                }
                else if (changeToReturn >= 100)
                {
                    count++;
                    changeToReturn -= 100;
                }
                else if (changeToReturn >= 50)
                {
                    count++;
                    changeToReturn -= 50;
                }
                else if (changeToReturn >= 20)
                {
                    count++;
                    changeToReturn -= 20;
                }
                else if (changeToReturn >= 10)
                {
                    count++;
                    changeToReturn -= 10;
                }
                else if (changeToReturn >= 5)
                {
                    count++;
                    changeToReturn -= 5;
                }
                else if (changeToReturn >= 2)
                {
                    count++;
                    changeToReturn -= 2;
                }
                else if (changeToReturn >= 1)
                {
                    count++;
                    changeToReturn -= 1;
                }
                else
                {
                    changeToReturn = 0;
                }
            }
            Console.WriteLine(count);
            
        }
    }
}
