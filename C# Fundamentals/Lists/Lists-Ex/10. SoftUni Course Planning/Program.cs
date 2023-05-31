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
                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Add(lessonTitle);
                    }
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
                    if(courses.Contains(lessonTitle) && courses.Contains(secondTitle))
                    {
                        int firstIndex = courses.IndexOf(lessonTitle);
                        int secondIndex = courses.IndexOf(secondTitle);
                        string firstCourse = courses[firstIndex];
                        string secondCourse = courses[secondIndex];
                        courses[firstIndex] = secondCourse;
                        courses[secondIndex] = firstCourse;
                    }
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
            if (courses.Contains(lessonTitle))
            {
                int index = courses.IndexOf(lessonTitle);
                courses[index] += "-Exercise";
            }
            else
            {
                courses.Add(lessonTitle);
            }
            int titleIndex = -1;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == lessonTitle) titleIndex = i;
            }   
            courses.Insert(titleIndex + 1, lessonTitle + "-Exercise");
            return courses;
        }
        static List<string> RearrangeExercises(List<string> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i + 1].Contains("-Exercise") && list[i + 1] != list[i] + "-Exercise")
                    for (int j = 0; j < list.Count; j++)
                        if (list[i + 1] == list[j] + "-Exercise")
                        {
                            string temp = list[i + 1];
                            list.RemoveAt(i + 1);
                            list.Insert(j + 1, temp);
                        }
            return list;
        }
    }
}
