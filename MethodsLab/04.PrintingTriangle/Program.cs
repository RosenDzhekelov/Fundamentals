using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                UpperHalfOfTriangle(i);
            }
            for (int i = input; i >0; i--)
            {
                LowerHalfOfTriangle(i);
            }
        
        }
        static void UpperHalfOfTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void LowerHalfOfTriangle(int input)
        {
            for (int j = 1; j < input; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
