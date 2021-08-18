using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociateArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.Where(x=> x!=' ').ToArray();
            var letterOccur = new Dictionary<char, int>();
            foreach (var item in letters)
            {
                if(letterOccur.ContainsKey(item))
                {
                    letterOccur[item]++;
                }
                else
                {
                    letterOccur.Add(item, 1);
                }
            }
            foreach (var item in letterOccur)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
