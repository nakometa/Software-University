using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramSticks = int.Parse(Console.ReadLine());

            double videoCardsCost = videocards * 250;
            double processorsCost = (videoCardsCost * 0.35) * processors;
            double ramSticksCost = (videoCardsCost * 0.10) * ramSticks;

            double totalCost = videoCardsCost + processorsCost + ramSticksCost;
            if (videocards > processors)
            {
                totalCost *= 0.85; // Отстъпка
            }

            if (totalCost <= budget)
            {
                Console.WriteLine($"You have {budget - totalCost:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:F2} leva more!");
            }
        }
    }
}
