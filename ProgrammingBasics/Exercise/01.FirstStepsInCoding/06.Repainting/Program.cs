using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int diluentNeeded = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonCost = (nylonNeeded + 2) * 1.50;
            double paintCost = (paintNeeded * 1.10) * 14.50;
            double diluentCost = diluentNeeded * 5.00;
            double materialCost = nylonCost + paintCost + diluentCost + 0.40;
            double laborCost = (materialCost * 0.30) * hoursNeeded;

            double totalCost = materialCost + laborCost;
            Console.WriteLine(totalCost);
        }
    }
}
