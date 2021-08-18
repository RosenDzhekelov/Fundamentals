using System;

namespace PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double beltTotal = beltPrice * studentCount - (studentCount / 6) * beltPrice;
            double robeTotal = robePrice * studentCount;
            double saberTotal = lightSaberPrice * (studentCount + Math.Ceiling(studentCount * 0.1));
            double priceTot = saberTotal + beltTotal + robeTotal;
            if(priceTot<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {priceTot:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {priceTot-money:f2}lv more.");
            }
            
        }
    }
}
