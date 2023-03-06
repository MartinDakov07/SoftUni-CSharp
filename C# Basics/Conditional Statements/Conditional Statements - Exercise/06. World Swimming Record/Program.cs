using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secFor1m = double.Parse(Console.ReadLine());
            //Izchislqvame kolko sec shte izmine za x metra
            //съпротивлението на водата го забавя на всеки 15 м. с 12.5 sekundi
            double metersDownPerMeters = Math.Floor(meters / 15);
            double metersDown = metersDownPerMeters * 12.5;
            double allTime = meters * secFor1m;
            //Obshto vreme na Ivan 
            double totalTime = allTime + metersDown; // vreme na Ivan = totalTime

            //Razlika v rekorda na Ivan i 
             
            if (totalTime >= record )
            {
                double difference = record - totalTime;
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
                
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(totalTime):f2} seconds.");
            }
        }
    }
}
