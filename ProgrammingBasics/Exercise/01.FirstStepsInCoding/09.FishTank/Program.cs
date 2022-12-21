using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double filledPercent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double waterVolume = (volume * 0.001) * (1 - (filledPercent / 100));
            Console.WriteLine(waterVolume);
        }
    }
}
