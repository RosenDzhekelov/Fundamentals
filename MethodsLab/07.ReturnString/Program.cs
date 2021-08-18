using System;

namespace _07.ReturnString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(text,times));
        }

        static string RepeatedString(string text , int times)
        {
            string holder = text;
            for (int i = 1; i < times; i++)
            {
                text += holder;
            }
            return text;
        }
    }
}
