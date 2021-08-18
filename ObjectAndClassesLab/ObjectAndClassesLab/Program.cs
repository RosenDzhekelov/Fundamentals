using System;

namespace ObjectAndClassesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int pos = rnd.Next(text.Length);
                string word = text[i];
                text[i] = text[pos];
                text[pos] = word;
            }
            Console.Write(String.Join(Environment.NewLine,text));
                
        }
    }
}
