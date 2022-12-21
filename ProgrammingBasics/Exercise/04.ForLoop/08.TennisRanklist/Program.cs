using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int pointsWon = 0;
            int tournamentsWon = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string tournamentStage = Console.ReadLine();

                switch (tournamentStage)
                {
                    case "W":
                        pointsWon += 2000;
                        tournamentsWon++;
                        break;
                    case "F":
                        pointsWon += 1200;
                        break;
                    case "SF":
                        pointsWon += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + pointsWon}");
            Console.WriteLine($"Average points: {pointsWon / tournaments}");
            Console.WriteLine($"{(tournamentsWon * 1.0 / tournaments) * 100:F2}%");

        }
    }
}
