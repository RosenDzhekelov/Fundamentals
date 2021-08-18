using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            bool isPositive = MultiplicationSign(firstNum,secondNum);
            if((thirdNum>0 && isPositive)  || (thirdNum<0 && !isPositive))
            {
                Console.WriteLine("positive");
            }
            else if(thirdNum == 0 || firstNum == 0 || secondNum == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("negative");
            }
            
          
            








        }
        static bool MultiplicationSign(int firstNum , int secondNum)
        {
            bool isPositive = false;
            if(firstNum>0 && secondNum>0 || (firstNum<0 && secondNum<0))
            {
                isPositive = true;
                return isPositive;
            }
            else
            {
                return isPositive;
            }
        }



    }
}
