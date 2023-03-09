using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int peopleInGroup = 0;
            double musala =0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            for (int i = 1; i <= n; i++)
            {

                peopleInGroup = int.Parse(Console.ReadLine());
               // Група до 5 човека – изкачват Мусала

              //  Група от 6 до 12 човека – изкачват Монблан

              //  Група от 13 до 25 човека – изкачват Килиманджаро
                
               // Група от 26 до 40 човека – изкачват К2

               // Група от 41 или повече човека – изкачват Еверест
                if (peopleInGroup <= 5)
                {
                    musala+=peopleInGroup;
                }

                else if (peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }

                else if (peopleInGroup <= 25)
                {
                    kilimandjaro += peopleInGroup;
                }

                else if (peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }

                else if (peopleInGroup >= 41)
                {
                    everest += peopleInGroup;
                }
            }
            double totalSumOfPeople = musala + monblan + kilimandjaro + k2 + everest;
            musala = musala / totalSumOfPeople * 100;
            monblan = monblan / totalSumOfPeople * 100;
            kilimandjaro =kilimandjaro / totalSumOfPeople * 100;
            k2 = k2 / totalSumOfPeople * 100;
            everest = everest / totalSumOfPeople * 100;
            
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
