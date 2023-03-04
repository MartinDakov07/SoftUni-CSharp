using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packetsOfPens = int.Parse(Console.ReadLine());
            int packetsOfMarkers = int.Parse(Console.ReadLine());
            int litersForPreparat = int.Parse(Console.ReadLine());
            double sale = double.Parse(Console.ReadLine()) / 100;
            double penPrice = packetsOfPens * 5.80;
            double markersPrice = packetsOfMarkers * 7.20;
            double preparat = litersForPreparat * 1.20;
            double totalPrice = penPrice + markersPrice + preparat;
            totalPrice = totalPrice - (totalPrice * sale);
            Console.WriteLine(totalPrice);
        }
    }
}
