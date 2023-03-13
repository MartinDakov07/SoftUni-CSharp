using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {          
             string name = Console.ReadLine();
            int failCount = 0;
            double score = double.Parse(Console.ReadLine());
            int classCount = 1;
            double averageScore = 0;
            double totalScore = 0;
            while(classCount <= 12)
            {          
                if (score < 4.00)
                {
                    failCount++;
                }
                if (failCount == 2)
                {
                    classCount--;
                    Console.WriteLine($"{name} has been excluded at {classCount} grade");
                    
                }
                totalScore += score;
                averageScore = totalScore / classCount;
                classCount++;
                if(classCount > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {averageScore:f2}");
                    break;
                }
                score = double.Parse(Console.ReadLine());
            }
            
        }
    }
}
