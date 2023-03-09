using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;
            for(int i =1; i <=age; i++)
            {
                if (i%2==0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }               
            }
            if (money >= laundry)
            {
                Console.WriteLine($"Yes! {(money - laundry):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(laundry - money):f2}");
            }
        }
    }
}
