using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamMember
{

    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }




    public class Family
    {
        public List<Person> MembersList { get; set; }

        public Family()
        {
            MembersList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            MembersList.Add(member);
        }

        public Person GetOldestMember()
        {
            return MembersList.OrderByDescending(p => p.Age).First();
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}