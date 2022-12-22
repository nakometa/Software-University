using System;

namespace _01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peolple = int.Parse(Console.ReadLine());
            double taxEntrance = double.Parse(Console.ReadLine());
            double pricePerDeckChair = double.Parse(Console.ReadLine());
            double pricePerUmbrella = double.Parse(Console.ReadLine());

            // Calculations
            double TaxMoney = peolple * taxEntrance;
            double DeckChairMoney = Math.Ceiling((peolple * 0.75)) * pricePerDeckChair;
            double UmbrellaMoney = Math.Ceiling((peolple * 0.5)) * pricePerUmbrella;
            double totalMoneyCollected = TaxMoney + DeckChairMoney + UmbrellaMoney;

            // Output
            Console.WriteLine($"{totalMoneyCollected:F2} lv.");
        }
    }
}
