using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int feeCost = int.Parse(Console.ReadLine());
            double shoeCost = feeCost * 0.60;
            double jerseyCost = shoeCost * 0.80;
            double basketballCost = jerseyCost * 0.25;
            double accessoriesCost = basketballCost * 0.20;

            double totalCost = shoeCost + jerseyCost + basketballCost + accessoriesCost + feeCost;

            Console.WriteLine(totalCost);
        }
    }
}
