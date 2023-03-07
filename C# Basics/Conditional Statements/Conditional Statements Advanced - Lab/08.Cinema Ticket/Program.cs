using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Monday Tuesday Wednesday Thursday Friday Saturday Sunday

            // 12 12 14 14 12 16 16
            string dayOfWeek = Console.ReadLine();
            int priceTicket = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                    priceTicket = 12;
                    break;
                case "Tuesday":
                    priceTicket = 12;
                    break;
                case "Wednesday":
                    priceTicket = 14;
                    break;
                case "Thursday":
                    priceTicket = 14;
                    break;
                case "Friday":
                    priceTicket = 12;
                    break;
                case "Saturday":
                    priceTicket = 16;
                    break;
                case "Sunday":
                    priceTicket = 16;
                    break;
            }
            Console.WriteLine(priceTicket);
        }
    }
}
