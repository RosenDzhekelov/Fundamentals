
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociateArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new SortedDictionary<double, int>();
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var key in input)
            {
                if(numbers.ContainsKey(key))
                {
                    numbers[key]++;
                }
                else
                {
                    numbers.Add(key, 1);
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
