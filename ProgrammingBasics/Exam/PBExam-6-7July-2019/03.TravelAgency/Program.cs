using System;

namespace _03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            bool isValid = true;
            double pricePerDay = 0;

            // Calculations
            switch (city)
            {
                case "Bansko":
                case "Borovets":
                    switch (packet)
                    {
                        case "noEquipment":
                            switch (vip)
                            {
                                case "yes":
                                    pricePerDay = 80 * 0.95;
                                    break;
                                case "no":
                                    pricePerDay = 80;
                                    break;
                            }
                            break;
                        case "withEquipment":
                            switch (vip)
                            {
                                case "yes":
                                    pricePerDay = 100 * 0.9;
                                    break;
                                case "no":
                                    pricePerDay = 100;
                                    break;
                            }
                            break;
                        default:
                            isValid = false;
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (packet)
                    {
                        case "noBreakfast":
                            switch (vip)
                            {
                                case "yes":
                                    pricePerDay = 100 * 0.93;
                                    break;
                                case "no":
                                    pricePerDay = 100;
                                    break;
                            }
                            break;
                        case "withBreakfast":
                            switch (vip)
                            {
                                case "yes":
                                    pricePerDay = 130 * 0.88;
                                    break;
                                case "no":
                                    pricePerDay = 130;
                                    break;
                            }
                            break;
                        default:
                            isValid = false;
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    break;
                default:
                    isValid = false;
                    Console.WriteLine("Invalid input!");
                    break;
            }
            double totalPrice = pricePerDay * days;
            if (days > 7)
            {
                totalPrice = totalPrice - pricePerDay;
            }
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (days >= 1 && isValid)
            {
                Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");
            }
        }
    }
}
