using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackages = int.Parse(Console.ReadLine());
            int markerPackages = int.Parse(Console.ReadLine());
            int boardCleaners = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            //* (discountPercent / 100);

            double total = penPackages * 5.80 + markerPackages * 7.20 + boardCleaners * 1.20;
            double discount = (total * discountPercent) * 0.01;

            Console.WriteLine(total - discount);
        }
    }
}
