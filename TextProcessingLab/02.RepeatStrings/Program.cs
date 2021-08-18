using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string text = Console.ReadLine();

            while(text.Contains(remove))
            {
                int index = text.IndexOf(remove);
                text = text.Remove(index, remove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
