using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJudge = int.Parse(Console.ReadLine());
            string namePresentation = Console.ReadLine();
            double grade = 0;
            double averageGrade = 0;
            int presentationCount = 0;

            while (namePresentation != "Finish")
            {
                grade = 0;
                for (int i = 0; i < numJudge; i++)
                {
                    grade += double.Parse(Console.ReadLine());

                }
                grade = grade / numJudge;
                Console.WriteLine($"{namePresentation} - {grade}.");
                presentationCount++;
                averageGrade += grade;
                namePresentation = Console.ReadLine();
            }
            averageGrade = averageGrade / presentationCount;
            Console.WriteLine($"Student's final assessment is {averageGrade}.");
        }
    }
}
