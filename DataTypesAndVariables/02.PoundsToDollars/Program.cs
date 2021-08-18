using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollar = decimal.Parse(Console.ReadLine());
            decimal pound = dollar * 1.31m;
            Console.WriteLine($"{pound:f3}");
        }
    }
}
