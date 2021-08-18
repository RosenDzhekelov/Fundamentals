using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string reversedString = string.Join("", firstString.Reverse());
            Console.WriteLine(reversedString);
        } 
    }
}
