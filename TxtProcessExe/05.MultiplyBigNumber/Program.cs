using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            int result = 0;
            int overTen = 0;
            StringBuilder product = new StringBuilder();
            for (int i = number.Length-1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                if (i == 0)
                {
                    result = digit * times + overTen;
                }
                else
                {
                    result = (digit * times) + overTen;
                    if (result >= 10)
                    {
                        overTen = result / 10;
                        result = result % 10;
                    }
                    else
                    {
                        overTen = 0;
                    }
                }
                product.Insert(0, result);
            }
            if (times != 0)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
