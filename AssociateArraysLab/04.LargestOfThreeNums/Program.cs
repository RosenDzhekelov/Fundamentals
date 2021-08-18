using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LargestOfThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x=> x)
                .ToList();
          
            int count = input.Count >= 3 ? 3 : input.Count;
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(input[i]);
            }
            Console.WriteLine(String.Join(" ",result));


        }
    }
}
