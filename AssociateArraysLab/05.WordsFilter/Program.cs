using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordsFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Where(x => x.Length % 2 == 0)
                 .ToList();
            input.ForEach(x => Console.WriteLine(x));

        }
    }
}
