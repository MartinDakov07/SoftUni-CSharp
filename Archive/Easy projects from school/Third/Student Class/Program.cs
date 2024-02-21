using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading;
namespace TheStudentClass
{
    public class Student
    {
        private string FullName;        
        private string Course;
        private string Specialty;
        private string University;
        private string Email;
        private string PhoneNumber;
        public Student()//При инициализация без подадени параметри, полетата се инициализират съответно с null или 0
        {
            this.FullName = null;            
            this.Course = null;
            this.Specialty = null;
            this.University = null;
            this.Email = null;
            this.PhoneNumber = null;
        }
        public Student(string firstName, string course, string specialty, string university, string email, string phoneNumber)
        {
            //Конструктор с пълен списък от параметри
            this.FullName = firstName;           
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
