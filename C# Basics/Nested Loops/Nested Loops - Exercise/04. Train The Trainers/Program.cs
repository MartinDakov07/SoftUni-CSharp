using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJudge = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double grade = 0;
            int presentationCount = 0;
            double averageGrade = 0;
            while (nameOfPresentation != "Finish")
            {
                grade = 0;
                for (int i = 1; i <= numJudge; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                    
                }
                grade = grade / numJudge;

                Console.WriteLine($"{nameOfPresentation} - {grade:f2}.");

                averageGrade += grade;

                presentationCount++;
                nameOfPresentation = Console.ReadLine();
            }
            averageGrade =averageGrade / presentationCount;
            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        }
    }
}
