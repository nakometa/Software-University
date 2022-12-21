using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double lunchTime = breakLength * 0.125;
            double restTime = breakLength * 0.25;
            double timeLeft = breakLength - (lunchTime + restTime);

            if (timeLeft >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodeLength - timeLeft)} more minutes.");
            }
        }
    }
}
