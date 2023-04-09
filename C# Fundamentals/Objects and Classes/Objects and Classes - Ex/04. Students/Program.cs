using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numOfStudents; i++) 
            {
                string[] studentArg = Console.ReadLine().Split(" ");
                var studentInfo = new Student(studentArg[0], studentArg[1], double.Parse(studentArg[2]));
                students.Add(studentInfo);
            }
            foreach(Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}
