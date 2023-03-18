using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double otherStudents =  students * 0.1;
            int freeBelts = 0;
            double totalPrice = 0;
            if (students / 6 != 0) 
            {
                freeBelts = students / 6;
                
            }                       
                totalPrice = lightsaberPrice * (Math.Ceiling(students + otherStudents)) + robePrice * (students) + beltsPrice * (students - freeBelts);
            
            
            if(totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {(totalPrice):f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice-money):f2}lv more.");
            }
        }
    }
}
