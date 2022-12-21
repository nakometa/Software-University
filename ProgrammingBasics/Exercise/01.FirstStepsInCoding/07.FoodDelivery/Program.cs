using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegeterianMenus = int.Parse(Console.ReadLine());

            double totalMenuCost = (chickenMenus * 10.35) + (fishMenus * 12.40) + (vegeterianMenus * 8.15);
            double dessertCost = totalMenuCost * 0.20;
            double totalCost = totalMenuCost + dessertCost + 2.50;

            Console.WriteLine(totalCost);
        }
    }
}
