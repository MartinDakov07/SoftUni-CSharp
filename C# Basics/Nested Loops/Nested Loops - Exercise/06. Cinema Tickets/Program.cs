using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int studentsTickets = 0;
            int standartTickets = 0;           
            int kidsTickets = 0;
           
            
               while(input != "Finish")
               {
                  int freeSpace = int.Parse(Console.ReadLine());
                   string ticketType = Console.ReadLine();
                    int tickets = 0;
                  while (ticketType != "End")
                  {
                    if (ticketType == "student")
                    {
                        studentsTickets++;
                    }
                    else if(ticketType == "standart")
                    {
                        standartTickets++;
                    }                
                    else 
                    {
                        kidsTickets++;
                    }
                    tickets++;
                    if (freeSpace == tickets)
                    {
                        break;
                    }
                    
                    ticketType = Console.ReadLine();
                    
                  }
                 double occupation = tickets * 100.00 / freeSpace;
                 Console.WriteLine($"{input} - {occupation:f2}% full.");
                 input = Console.ReadLine();
                }
            int totalTickets = kidsTickets + standartTickets + studentsTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentsTickets * 100.00 / totalTickets):f2}% student tickets.");
            Console.WriteLine($"{(standartTickets * 100.00 / totalTickets):f2}% standard tickets.");
            Console.WriteLine($"{(kidsTickets * 100.00 / totalTickets):f2}% kids tickets.");
          
        }
           
    }
}
