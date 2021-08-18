using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = int.Parse(Console.ReadLine());
            BigInteger secondNum = int.Parse(Console.ReadLine());
            if (Factorial(firstNum) / Factorial(secondNum) > 0)
            {
                BigInteger result = Factorial(firstNum) / Factorial(secondNum);
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                double result = (double)Factorial(firstNum) / (double)Factorial(secondNum);
                Console.WriteLine($"{result:f2}") ;
            }
            
        }

        static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorial = 1;
         
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
           
            return factorial;
        }
    }
}
