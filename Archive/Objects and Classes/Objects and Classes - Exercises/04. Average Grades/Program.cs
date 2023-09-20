using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _04._Average_Grades
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade => Grades.Average();            
        }
        static void Main(string[] args)
        {
            List<Student> studentGrades = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] studentArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = studentArg[0];
                double averageGrade = 0;
               
                Student student = new Student() { Name = name, Grades = new List<double>() };
                for (int j = 1; j < studentArg.Length; j++)
                {
                    student.Grades.Add(double.Parse(studentArg[j]));
                }
                studentGrades.Add(student);
            }
            foreach(var grade in studentGrades.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).Where(x=>x.AverageGrade >= 5.00))
            {
                Console.WriteLine($"{grade.Name} -> {grade.AverageGrade:f2}");
            }
        }
    }
}
