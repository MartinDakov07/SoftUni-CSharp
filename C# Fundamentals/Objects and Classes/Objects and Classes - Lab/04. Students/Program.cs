using System;
using System.Collections.Generic;
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while(line != "end")
            {
                string[] studArg = line.Split();

                string firstName = studArg[0];
                string lastName = studArg[1];
                int age = int.Parse(studArg[2]);
                string city = studArg[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;
                bool isExisting = false;
                foreach (var currStudent in students)
                {
                    if (currStudent.FirstName == student.FirstName && currStudent.LastName == student.LastName)
                    {
                        currStudent.Age = student.Age;
                        currStudent.City = student.City;
                        isExisting = true;
                    }
                }
                if (!isExisting)
                {
                    students.Add(student);
                }
                
               
                
                line = Console.ReadLine();
            }
            string filterTown = Console.ReadLine();
            foreach(Student student in students)
            {
                if(student.City == filterTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
