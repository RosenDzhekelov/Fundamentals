using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            string allTogether = firstName + delimeter + secondName;
            Console.WriteLine(allTogether);
        }
    }
}
