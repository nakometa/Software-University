using System;

namespace _03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksAmount = int.Parse(Console.ReadLine());

            double priceForTheDrink = 0;
            bool moreThanFive = false;
            // Calculations
            switch (drink)
            {
                case "Espresso":
                    if (drinksAmount >= 5)
                    {
                        moreThanFive = true;
                    }
                    switch (sugar)
                    {
                        case "Without":
                            priceForTheDrink = 0.9 * 0.65;
                            break;
                        case "Normal":
                            priceForTheDrink = 1;
                            break;
                        case "Extra":
                            priceForTheDrink = 1.2;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            priceForTheDrink = 1 * 0.65;
                            break;
                        case "Normal":
                            priceForTheDrink = 1.2;
                            break;
                        case "Extra":
                            priceForTheDrink = 1.6;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            priceForTheDrink = 0.5 * 0.65;
                            break;
                        case "Normal":
                            priceForTheDrink = 0.6;
                            break;
                        case "Extra":
                            priceForTheDrink = 0.7;
                            break;
                    }
                    break;

            }
            double totalPrice = priceForTheDrink * drinksAmount;
            if (moreThanFive)
            {
                totalPrice = totalPrice * 0.75;
            }
            if (totalPrice > 15)
            {
                totalPrice = totalPrice * 0.8;
            }
            Console.WriteLine($"You bought {drinksAmount} cups of {drink} for {totalPrice:F2} lv.");

        }
    }
}
