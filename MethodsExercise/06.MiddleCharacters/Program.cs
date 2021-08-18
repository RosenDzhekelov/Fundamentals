using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintTheMiddleChar(text);
        }

        static void PrintTheMiddleChar(string text)
        {
            if (text.Length % 2 == 1)
            {
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
        }
    }
}
