using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int nailonQuantity = int.Parse(Console.ReadLine());
            double paintQuantity = double.Parse(Console.ReadLine());
            double thinnerLiters = double.Parse(Console.ReadLine());

            paintQuantity = paintQuantity + paintQuantity * 0.10;
            

            //Price for every resource
            double nailonPrice = (nailonQuantity + 2) * 1.50;
            double paintPrice = paintQuantity * 14.50;
            double thinnerPrice = thinnerLiters * 5.00;
            // Price for all materials + torbichka ot 40 st.
            double materialsSum = nailonPrice + paintPrice + thinnerPrice + 0.40;
            // Price for workers per hour 
            int workersHours = int.Parse(Console.ReadLine());
            double workersPricePerHour = materialsSum * 0.30;
            // Total price for everything 
            double workersSum = workersPricePerHour * workersHours;
            double totalSum = workersSum + materialsSum;
            Console.WriteLine(totalSum);
            
        }
    }
}
