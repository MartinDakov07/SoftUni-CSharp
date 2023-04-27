using System;
using System.Linq;
using System.Numerics;
namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCount = 0;
            int totalEmployee = firstEmployee + secondEmployee + thirdEmployee;
            if(studentsCount == 0)
            {
                Console.WriteLine($"Time needed: 0h.");
                return;
            }
            while(true)
            {
                hoursCount++;
                
                if (hoursCount % 4 == 0)
                {                   
                    continue;
                }
                studentsCount -= totalEmployee;
                if (studentsCount <= 0)
                {
                    break;
                }

            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
