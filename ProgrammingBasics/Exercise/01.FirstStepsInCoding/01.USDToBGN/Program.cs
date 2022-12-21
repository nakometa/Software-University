using System;

namespace _01.USDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            const double usdCourse = 1.79549;

            Console.WriteLine(usd * usdCourse);
        }
    }
}
