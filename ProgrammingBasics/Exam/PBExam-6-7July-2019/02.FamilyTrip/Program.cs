using System;

namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double additionalCostPercent = double.Parse(Console.ReadLine());

            // Calculations
            if (nights > 7)
            {
                pricePerNight = pricePerNight * 0.95;
            }
            double stayTimeCost = pricePerNight * nights;
            double additionalCost = budget * (additionalCostPercent / 100);
            double totalCost = stayTimeCost + additionalCost;

            if (budget >= totalCost)
            {
                double moneyLeft = budget - totalCost;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
            }
            else
            {
                double moneyNeeded = totalCost - budget;
                Console.WriteLine($"{moneyNeeded:F2} leva needed.");
            }
        }
    }
}
