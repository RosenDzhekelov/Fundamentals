using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrays = input.Split('|',StringSplitOptions.RemoveEmptyEntries);
            List<int> mergedArrays = new List<int>();
            for (int i = 0; i < arrays.Length; i++)
            {
                List<int> appendArray = arrays[arrays.Length - 1 - i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                for (int index = 0; index < appendArray.Count; index++)
                {
                   
                    mergedArrays.Add(appendArray[index]);
                }
            }
            Console.WriteLine(String.Join(" ",mergedArrays));
        }
    }
}
