using System;
using System.Linq;

namespace TextProcessingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input!="end")
            {
                string reversed = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    reversed += input[input.Length - 1 - i];
                }
                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }
    }
}
