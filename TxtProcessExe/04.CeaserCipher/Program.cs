using System;
using System.Text;

namespace _04.CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char shifted = (char)(input[i] + 3);
                encrypted.Append(shifted);
            }
            Console.WriteLine(encrypted);
        }
    }
}
