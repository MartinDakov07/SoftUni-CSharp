using System;

namespace _06.Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string ticketType;
            int freeSpace;
            int studentsCount = 0;
            int standartCount = 0;
            int kidsCount = 0;
            int allTickets = 0;
            
           
            
            while (filmName != "Finish")
            {
                freeSpace = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();
                allTickets = 0;
                while (ticketType != "End")
                {                
                    if(ticketType == "standart")
                    {

                        standartCount++;
                    }
                    else if(ticketType == "students")
                    {
                        studentsCount++;
                    }
                    else
                    {
                        kidsCount++;
                    }
                    allTickets++;
                    if(allTickets == freeSpace)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();    
                }

                double occupation = allTickets * 100 / freeSpace;
                Console.WriteLine($"{filmName} - {occupation:f2}% full.");
                filmName = Console.ReadLine();
            }
            int totalTickets = standartCount + studentsCount + kidsCount;
            Console.WriteLine($"Total tickets:{totalTickets}");
            Console.WriteLine($"{(studentsCount * 100 / totalTickets):f2}% student tickets.");
            Console.WriteLine($"{(standartCount * 100 / totalTickets):f2}% standard tickets.");
            Console.WriteLine($"{(kidsCount * 100 / totalTickets):f2}% kids tickets.");

        }
    }
}
