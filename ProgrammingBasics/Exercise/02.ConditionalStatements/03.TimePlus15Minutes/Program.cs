using System;

namespace _03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = (hour * 60) + minutes;
            int timeAfterFifteenMinutes = timeInMinutes + 15;

            int hourAfterFifteenMinutes = timeAfterFifteenMinutes / 60;
            int minutesAfterFifteenMinutes = timeAfterFifteenMinutes % 60;

            if (hourAfterFifteenMinutes == 24)
            {
                hourAfterFifteenMinutes = 0;
            }

            Console.WriteLine($"{hourAfterFifteenMinutes}:{minutesAfterFifteenMinutes:d2}");
        }
    }
}
