using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double headsetTot = (lostGames / 2) * headsetPrice;
            double mouseTot = (lostGames / 3) * mousePrice;
            double keyboardTot = (lostGames / 6) * keyboardPrice;
            double displayTot = (lostGames / 12) * displayPrice;
            double rageExpenses = displayTot + keyboardTot + mouseTot + headsetTot;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
