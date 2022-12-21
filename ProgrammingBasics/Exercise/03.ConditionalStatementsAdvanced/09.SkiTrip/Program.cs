using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double totalPrice = 0;

            switch (roomType)
            {
                case "room for one person":
                    totalPrice = nights * 18;
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        totalPrice = (nights * 25) * 0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = (nights * 25) * 0.65;
                    }
                    else
                    {
                        totalPrice = (nights * 25) * 0.50;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        totalPrice = (nights * 35) * 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = (nights * 35) * 0.85;
                    }
                    else
                    {
                        totalPrice = (nights * 35) * 0.80;
                    }
                    break;
            }

            if (feedback == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
