using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyGift = 10;
            int toys = 0;
            int totalMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += moneyGift - 1;
                    moneyGift += 10;
                }
                else
                {
                    toys++;
                }
            }

            totalMoney += toys * toyPrice;

            if (totalMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - laundryPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryPrice - totalMoney:F2}");
            }
        }
    }
}
