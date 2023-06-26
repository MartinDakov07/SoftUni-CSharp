using System;

namespace _04._Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            decimal studioPrice = 0;
            decimal doublePrice = 0;
            decimal suitePrice = 0;
            decimal studio = 0;
            decimal doublePr = 0;
            decimal suite = 0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                doublePr = 65;
                suite = 75;
                if (days > 7)
                {
                    studio = studio - studio * 0.05m;
                }
                studioPrice = studio * days;
                doublePrice = doublePr * days;
                suitePrice = suite * days;
                
                if(month == "October" && days > 7)
                {
                    studioPrice -= studio;
                }
            }
            else if(month == "June" || month == "September")
            {
                studio = 60;
                doublePr = 72;
                suite = 82;
                if (days > 14)
                {
                    doublePr = doublePr - doublePr * 0.1m;
                }
                studioPrice = studio * days;
                doublePrice = doublePr * days;
                suitePrice = suite * days;
                
                if(month == "September" && days > 7)
                {
                    studioPrice -= studio;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doublePr = 77;
                suite = 89;
                if (days > 14)
                {
                    suite = suite - suite * 0.15m;
                }
                studioPrice = studio * days;
                doublePrice = doublePr * days;
                suitePrice = suite * days;
                            
            }            
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
