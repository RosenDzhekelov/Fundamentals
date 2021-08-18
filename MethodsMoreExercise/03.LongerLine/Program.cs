using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondY = double.Parse(Console.ReadLine());

            double thirdX = double.Parse(Console.ReadLine());
            double thirdY = double.Parse(Console.ReadLine());
            double fourthX = double.Parse(Console.ReadLine());
            double fourthY = double.Parse(Console.ReadLine());


            double newFirstX = Math.Abs(firstX) + Math.Abs(secondX);
            double newFirstY = Math.Abs(firstY) + Math.Abs(secondY);
            double newSecondX = Math.Abs(thirdX) + Math.Abs(fourthX);
            double newSecondY = Math.Abs(thirdY) + Math.Abs(fourthY);
            string[] finalResult = ClosestToZero(newFirstX, newFirstY, newSecondX, newSecondY);
            if (double.Parse(finalResult[0]) == newFirstX && double.Parse(finalResult[1]) == newFirstY && newFirstX!=newSecondX && newFirstY!= newSecondY)
            {
                string[] secondResult = ClosestToZero(thirdX, thirdY, fourthX, fourthY);
                double closestX = double.Parse(secondResult[0]);
                double closestY = double.Parse(secondResult[1]);
                if (closestX == thirdX && closestY == thirdY)
                {
                    Console.WriteLine($"({thirdX}, {thirdY})({fourthX}, {fourthY})");
                }
                else
                {
                    Console.WriteLine($"({fourthX}, {fourthY})({thirdX}, {thirdY})");
                }
            }
            else
            {
                string[] secondResult = ClosestToZero(firstX, firstY, secondX, secondY);
                double closestX = double.Parse(secondResult[0]);
                double closestY = double.Parse(secondResult[1]);
                if (closestX == firstX && closestY == firstY)
                {
                    Console.WriteLine($"({firstX}, {firstY})({secondX}, {secondY})");
                }
                else
                {
                    Console.WriteLine($"({secondX}, {secondY})({firstX}, {firstY})");
                }
            }




        }
        static string[] ClosestToZero(double firstX, double firstY, double secondX, double secondY)
        {

            double differenceX = 0;
            double differenceY = 0;
            bool firstXisBigger = false;
            bool firstYisBigger = false;
            string[] result = new string[2];
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
                result[0] = secondX.ToString();
                result[1] = secondY.ToString();
                return result;
            }
            else if (!firstYisBigger && !firstXisBigger || (differenceX == 0 && differenceY == 0))
            {
                result[0] = firstX.ToString();
                result[1] = firstY.ToString();
                return result;
            }
            else if (firstXisBigger && !firstYisBigger)
            {
                if (differenceX > differenceY)
                {
                    result[0] = secondX.ToString();
                    result[1] = secondY.ToString();
                    return result;
                }
                else
                {
                    result[0] = firstX.ToString();
                    result[1] = firstY.ToString();
                    return result;
                }
            }
            else if (!firstXisBigger && firstYisBigger)
            {
                if (differenceX > differenceY)
                {
                    result[0] = firstX.ToString();
                    result[1] = firstY.ToString();
                    return result;
                }
                else
                {
                    result[0] = secondX.ToString();
                    result[1] = secondY.ToString();
                    return result;
                }
            }
            return result;
        }
    }
}
