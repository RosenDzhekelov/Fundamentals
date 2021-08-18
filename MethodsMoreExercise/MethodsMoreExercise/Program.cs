using System;

namespace MethodsMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondY = double.Parse(Console.ReadLine());
            double differenceX = 0;
            double differenceY = 0;
            bool firstXisBigger = false;
            bool firstYisBigger = false;
            if (Math.Abs(firstX) > Math.Abs(secondX))
            {
                differenceX = Math.Abs(firstX) - Math.Abs(secondX);
                firstXisBigger = true;
            }
            else
            {
                differenceX = Math.Abs(secondX) - Math.Abs(firstX);
            }
            if (Math.Abs(firstY) > Math.Abs(secondY))
            {
                differenceY = Math.Abs(firstY) - Math.Abs(secondY);
                firstYisBigger = true;
            }
            else
            {
                differenceY = Math.Abs(secondY) - Math.Abs(firstY);
            }
            if (firstYisBigger && firstXisBigger)
            {
                Console.WriteLine($"({secondX}, {secondY})");
            }
            else if (!firstYisBigger && !firstXisBigger || (differenceX == 0 && differenceY == 0))
            {
                Console.WriteLine($"({firstX}, {firstY})");
            }
            else if (firstXisBigger && !firstYisBigger)
            {
                if (differenceX > differenceY)
                {
                    Console.WriteLine($"({secondX}, {secondY})");
                }
                else
                {
                    Console.WriteLine($"({firstX}, {firstY})");
                }
            }
            else if (!firstXisBigger && firstYisBigger)
            {
                if (differenceX > differenceY)
                {
                    Console.WriteLine($"({firstX}, {firstY})");
                }
                else
                {
                    Console.WriteLine($"({secondX}, {secondY})");
                }
            }
        }
    }
}
