using System;

namespace MethodsMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Integer(text);
            Real(text);
            IfString(text);
        }
        static void Integer(string text)
        {
            if (text == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
        }
        static void Real(string text)
        {
            if (text == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
        }
        static void IfString(string text)
        {
            if (text == "string")
            {
                string someText = Console.ReadLine();
                Console.WriteLine($"${someText}$");
            }
        }
    }
}
