using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isEqual = false;
            if(firstNum<0)
            {
                firstNum *= -1;
            }
            if(secondNum<0)
            {
                secondNum *= -1;
            }
            if(firstNum>=secondNum &&firstNum - secondNum < eps)
            {
                    isEqual = true;
                    Console.WriteLine(isEqual);              
            }
            else if(secondNum>firstNum && secondNum-firstNum<eps)
            {
                isEqual = true;
                Console.WriteLine(isEqual);
            }    
            else
            {
                Console.WriteLine(isEqual);
            }
        }
    }
}
