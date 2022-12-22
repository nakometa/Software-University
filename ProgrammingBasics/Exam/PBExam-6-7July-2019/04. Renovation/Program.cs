using System;

namespace _04._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallLength = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            double wallPercentThatWontBePainted = double.Parse(Console.ReadLine());
            bool finished = false;
            // Calculations
            double amountToPaint = wallLength * wallWidth * 4;
            double totalAmountToPaint = Math.Ceiling(amountToPaint - amountToPaint * (wallPercentThatWontBePainted / 100));

            string input = Console.ReadLine();
            while (input != "Tired!")
            {
                int currentLiters = int.Parse(input);
                if (totalAmountToPaint < currentLiters)
                {
                    finished = true;
                    double litersLeft = currentLiters - totalAmountToPaint;
                    Console.WriteLine($"All walls are painted and you have {litersLeft} l paint left!");
                    break;
                }
                else if (totalAmountToPaint == currentLiters)
                {
                    finished = true;
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                totalAmountToPaint -= currentLiters;
                input = Console.ReadLine();
            }
            if (totalAmountToPaint > 0 && !finished)
            {
                Console.WriteLine($"{totalAmountToPaint} quadratic m left.");
            }
        }
    }
}
