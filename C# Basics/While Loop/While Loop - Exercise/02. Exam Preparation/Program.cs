using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string gradeName = Console.ReadLine();
            int grade;
            int badCounts = 0;
            double gradeSum = 0;
            int solvedProblems = 0;
            string lastProblem = string.Empty;
            while(gradeName != "Enough")
            {
                grade = int.Parse(Console.ReadLine());
                
                gradeSum += grade;
                solvedProblems++;
                lastProblem = gradeName;
                if (grade <= 4)
                {
                    badCounts++;
                    if (badCounts == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badCounts} poor grades.");
                        break;
                    }
                }                            
                
                gradeName = Console.ReadLine();
                
                
            }
            if (badCounts < badGrades)
            {
                Console.WriteLine($"Average score: {(gradeSum / solvedProblems):f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
                
            }




        }
    }
}
