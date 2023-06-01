using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            while((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArg[0];
                string lessonTitle = cmdArg[1];
                if (type == "Add")
                {
                    
                   courses.Add(lessonTitle);                    
                }
                else if (type == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Insert(index, lessonTitle);
                    }
                }
                else if (type == "Remove")
                {
                    if (courses.Contains(lessonTitle))
                    {
                        courses.Remove(lessonTitle);
                    }
                }
                else if (type == "Swap") 
                {
                    string secondTitle = cmdArg[2];
                    if (courses.Contains(lessonTitle) && courses.Contains(secondTitle))
                    {
                        int firstIndex = -1;
                        int secondIndex = -1;
                        for (int i = 0; i < courses.Count; i++)
                        {
                            if (courses[i] == lessonTitle) firstIndex = i;
                            else if (courses[i] == secondTitle) secondIndex = i;
                        }
                        string temp;
                        temp = courses[firstIndex];
                        courses[firstIndex] = courses[secondIndex];
                        courses[secondIndex] = temp;
                    }
                   
                    //if(courses.Contains(lessonTitle) && courses.Contains(secondTitle))
                    //{
                    //    int firstIndex = courses.IndexOf(lessonTitle);
                    //    int secondIndex = courses.IndexOf(secondTitle);
                    //    string firstCourse = courses[firstIndex];
                    //    string secondCourse = courses[secondIndex];
                    //    courses[firstIndex] = secondCourse;
                    //    courses[secondIndex] = firstCourse;
                    //}
                }
                else if(type == "Exercise")
                {
                    courses = Exercise(courses, lessonTitle);
                }
                courses = RearrangeExercises(courses);
            }
            int counter = 1;
            foreach(string lesson in courses)
            {
                Console.WriteLine($"{counter}.{lesson}");
                counter++;
            }
        }
        static List<string> Exercise(List<string> courses, string lessonTitle)
        {
            if (courses.Contains(lessonTitle + "-Exercise"))
            {
                return courses;
            }           
            if(!courses.Contains(lessonTitle))
            {
                courses.Add(lessonTitle);
            }
            int titleIndex = -1;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == lessonTitle)
                {
                    titleIndex = i;
                }
            }   
            courses.Insert(titleIndex + 1, lessonTitle + "-Exercise");
            return courses;
        }
        static List<string> RearrangeExercises(List<string> courses)
        {
            for (int i = 0; i < courses.Count - 1; i++)
            {
                if (courses[i + 1].Contains("-Exercise") && courses[i + 1] != courses[i] + "-Exercise")
                {
                    for (int j = 0; j < courses.Count; j++)
                    {
                        if (courses[i + 1] == courses[j] + "-Exercise")
                        {
                            string temp = courses[i + 1];
                            courses.RemoveAt(i + 1);
                            courses.Insert(j + 1, temp);
                        }
                    }                        
                }
            }                
            return courses;
        }
    }
}
