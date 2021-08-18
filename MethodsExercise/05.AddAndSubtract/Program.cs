using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = SumOfTwo(firstNum, secondNum);
            int result = SubtractTheSum(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }
        static int SumOfTwo(int firstNum , int secondNum)
        {
            int sum = 0;
            sum = firstNum + secondNum;
            return sum;
        }
        static int SubtractTheSum(int firstNum , int secondNum , int thirdNum)
        {
            int sum = SumOfTwo(firstNum,secondNum);
            int subtraction = sum - thirdNum;
            return subtraction;
        }
    }
}
