using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberPowered(number, power));
        }
        static double NumberPowered(double number , int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
           
        }
    }
}
