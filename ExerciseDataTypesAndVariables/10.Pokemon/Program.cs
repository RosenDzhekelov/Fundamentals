using System;

namespace _10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            int checker = pokePower;
            while(pokePower>=distance)
            {
                pokePower -= distance;
                counter++;
                if(checker*0.5==pokePower)
                {
                    if(exhaustionFactor!=0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
