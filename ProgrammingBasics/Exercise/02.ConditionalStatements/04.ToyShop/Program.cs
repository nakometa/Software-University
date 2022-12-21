using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrise = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = puzzles + dolls + teddybears + minions + trucks;
            double totalProfit = puzzles * 2.60 + dolls * 3 + teddybears * 4.10 + minions * 8.20 + trucks * 2;

            if (totalToys >= 50)
            {
                totalProfit *= 0.75; // 25% намаление при покупка на 50 или повече играчки
            }

            totalProfit *= 0.9; // изваждаме 10% за наема

            if (tripPrise <= totalProfit)
            {
                Console.WriteLine($"Yes! {totalProfit - tripPrise:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrise - totalProfit:F2} lv needed.");

            }
        }
    }
}
