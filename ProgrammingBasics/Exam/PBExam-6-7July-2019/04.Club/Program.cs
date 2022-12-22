using System;

namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wantedIncome = double.Parse(Console.ReadLine());
            string coctail = Console.ReadLine();
            double totalIncome = 0;
            bool targetAquired = false;

            while (coctail != "Party!")
            {
                int amount = int.Parse(Console.ReadLine());
                double currentIncome = 0;
                currentIncome = coctail.Length * amount;
                if (currentIncome % 2 != 0)
                {
                    currentIncome = currentIncome * 0.75;
                }
                totalIncome += currentIncome;
                if (totalIncome >= wantedIncome)
                {
                    targetAquired = true;
                    Console.WriteLine("Target acquired.");
                    break;
                }
                coctail = Console.ReadLine();
            }

            if (!targetAquired)
            {
                double moneyNeeded = wantedIncome - totalIncome;
                Console.WriteLine($"We need {moneyNeeded:F2} leva more.");
            }
            Console.WriteLine($"Club income - {totalIncome:F2} leva.");
        }
    }
}
