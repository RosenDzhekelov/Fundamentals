using System;

namespace _06.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width, height)); 
        }

        static int RectangleArea(int width , int height)
        {
            return width * height;
        }
    }
}
