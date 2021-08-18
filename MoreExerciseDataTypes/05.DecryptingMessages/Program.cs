using System;

namespace _05.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter =(char)((int)letter + key);
                 message += letter.ToString();
            }
            Console.WriteLine(message);
        }
    }
}
