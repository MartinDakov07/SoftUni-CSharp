using System;

namespace _19._Thea_The_Photographer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong totalPhotos = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            double percentToFilter = double.Parse(Console.ReadLine())/100;
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            ulong filteredPhotos = (ulong)Math.Ceiling((totalPhotos * percentToFilter));

            ulong timeForFilter = filterTime * totalPhotos;
            ulong uploadFilters = filteredPhotos * uploadTime;

            ulong totalTime = timeForFilter + uploadFilters;

            ulong days = 0;
            ulong hours = 0;
            ulong minutes = 0;
            if (totalTime >= 86400)
            {
                days = totalTime / 86400;
                totalTime -= 86400 * days;
            }
            if (totalTime >= 3600)
            {
                hours = totalTime / 3600;
                totalTime -= 3600 * hours;
            }
            if (totalTime >= 60)
            {
                minutes = totalTime / 60;
                totalTime -= 60 * minutes;
            }
            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{totalTime:d2}");
        }
    }
}
