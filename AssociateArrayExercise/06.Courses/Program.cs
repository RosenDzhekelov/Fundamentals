using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();

             while(input!="end")
            {
                string[] inputArgs = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string key = inputArgs[0];
                string value = inputArgs[1];
                if(!courses.ContainsKey(key))
                {
                    courses.Add(key, new List<string> { value });
                }
                else
                {
                    courses[key].Add(value);
                }



                input = Console.ReadLine();
            }
            foreach (var course in courses.OrderByDescending(course=> course.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var name in course.Value.OrderBy(x=> x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
