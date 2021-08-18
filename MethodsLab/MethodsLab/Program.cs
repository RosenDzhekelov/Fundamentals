using System;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignOfIntegerNumber(number);
        }
        static void SignOfIntegerNumber(int number)
        {
            string result = string.Empty;
            if(number>0)
            {
                result = "positive";
            }

            else if(number<0)
            {

                result = "negative";

            }

            else
            {
              
                result = "zero";

            }

            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
