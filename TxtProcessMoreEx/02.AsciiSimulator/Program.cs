using System;

namespace _02.AsciiSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(Math.Max(firstChar,secondChar)>input[i]&&Math.Min(firstChar,secondChar)<input[i])
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
