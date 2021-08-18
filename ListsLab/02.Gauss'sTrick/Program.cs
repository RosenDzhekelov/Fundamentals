using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_sTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split().Select(double.Parse).ToList();

            int limit = numbers.Count/2;
            for (int i = 0; i < limit; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                
            }
            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
