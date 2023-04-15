using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            int gradeCount = 1;
            for(int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!grades.ContainsKey(student))
                {
                    grades.Add(student, new List<double>());
                    grades[student].Add(grade);
                    grades[student].Add(gradeCount);
                }
                else
                {
                    grades[student][0] += grade;
                    grades[student][1]++;
                }
            }
            
            foreach(var student in grades)
            {
                if(student.Value[0] / student.Value[1] >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {(student.Value[0] / student.Value[1]):f2}");
                }
                
            }
        }
    }
}
