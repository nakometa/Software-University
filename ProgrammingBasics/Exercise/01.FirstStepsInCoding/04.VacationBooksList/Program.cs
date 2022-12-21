using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());

            int hoursNeeded = totalPages / pagesPerHour;
            int hoursPerDay = hoursNeeded / daysLeft;

            Console.WriteLine(hoursPerDay);
        }
    }
}
