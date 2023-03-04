using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pages of the book
            int pages = int.Parse(Console.ReadLine());
            //Pages per hour
            int pagesPerHour = int.Parse(Console.ReadLine());
            //Number of days that Joro needs to read the book
            int days = int.Parse(Console.ReadLine());
            //Hours needed for reading the whole book
            int hoursForTheBook = pages / pagesPerHour;
            //Hours per day
            int hoursPerDay = hoursForTheBook / days;
            Console.WriteLine(hoursPerDay);

        }
    }
}
