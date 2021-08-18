using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(MathOperation(firstNum, sign, secondNum));

        }
        static double MathOperation(double firstNum, string sign, double secondNum)
        {
            double result = 0;
            if (sign == "/")
            {
                result = firstNum / secondNum;
                return result;
            }
            else if (sign == "*")
            {
                result = firstNum * secondNum;
                return result;
            }
            else if (sign == "+")
            {
                result = firstNum + secondNum;
                return result;
            }
            else
            {
                result = firstNum - secondNum;
                return result;
            }


        }
    }
}
