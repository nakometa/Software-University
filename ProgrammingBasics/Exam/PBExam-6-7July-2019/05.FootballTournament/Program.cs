using System;

namespace _05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int playedMatches = int.Parse(Console.ReadLine());
            int wCounter = 0;
            int dCounter = 0;
            int lCoutner = 0;
            int points = 0;
            if (playedMatches == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
                Environment.Exit(0);
            }

            for (int i = 0; i < playedMatches; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        wCounter++;
                        points += 3;
                        break;
                    case "D":
                        dCounter++;
                        points++;
                        break;
                    case "L":
                        lCoutner++;
                        break;
                }
            }
            Console.WriteLine($"{name} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wCounter}");
            Console.WriteLine($"## D: {dCounter}");
            Console.WriteLine($"## L: {lCoutner}");
            Console.WriteLine($"Win rate: {(wCounter * 1.0 / playedMatches * 1.0) * 100:F2}%");
        }
    }
}
