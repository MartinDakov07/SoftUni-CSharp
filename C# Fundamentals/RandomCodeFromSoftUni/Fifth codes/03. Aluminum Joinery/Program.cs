using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDograms = int.Parse(Console.ReadLine());
            string typeOfDogram = Console.ReadLine();
            string command = Console.ReadLine();
            double price = 0;
            if(typeOfDogram == "90X130")
            {
                price = numOfDograms * 110;
                if(numOfDograms >= 30 && numOfDograms < 60)
                {
                    price = price - price * 0.05;
                }
                else if(numOfDograms >= 60)
                {
                    price = price - price * 0.08;
                }
            }
            else if(typeOfDogram == "100X150")
            {
                price = numOfDograms * 140;
                if (numOfDograms >= 40 && numOfDograms < 80)
                {
                    price = price - price * 0.06;
                }
                else if (numOfDograms >= 80)
                {
                    price = price - price * 0.1;
                }
            }
            else if (typeOfDogram == "130X180")
            {
                price = numOfDograms * 190;
                if (numOfDograms >= 20 && numOfDograms < 50)
                {
                    price = price - price * 0.07;
                }
                else if (numOfDograms >= 50)
                {
                    price = price - price * 0.12;
                }
            }
            else if (typeOfDogram == "200X300")
            {
                price = numOfDograms * 250;
                if (numOfDograms >= 25 && numOfDograms < 50)
                {
                    price = price - price * 0.09;
                }
                else if (numOfDograms >= 50)
                {
                    price = price - price * 0.14;
                }
            }
            if(numOfDograms < 10)
            {
                Console.WriteLine("Invalid order");
            }
            if(command == "With delivery")
            {
                price = price + 60;
            }
            else if(command == "Without delivery")
            {
                price = price;
            }
            if(numOfDograms >= 100)
            {
                price = price - price * 0.04;
            }
            if(numOfDograms >= 10)
            {
                Console.WriteLine($"{price:f2} BGN");
            }
           
        }
    }
}
