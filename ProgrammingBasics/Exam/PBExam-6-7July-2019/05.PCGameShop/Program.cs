using System;

namespace _05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            int HearthstoneCounter = 0;
            int ForniteCounter = 0;
            int OverwatchCounter = 0;
            int OthersCounter = 0;

            for (int i = 0; i < soldGames; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        HearthstoneCounter++;
                        break;
                    case "Fornite":
                        ForniteCounter++;
                        break;
                    case "Overwatch":
                        OverwatchCounter++;
                        break;
                    default:
                        OthersCounter++;
                        break;
                }

            }
            Console.WriteLine($"Hearthstone - {HearthstoneCounter * 1.0 / soldGames * 100:F2}%");
            Console.WriteLine($"Fornite - {ForniteCounter * 1.0 / soldGames * 100:F2}%");
            Console.WriteLine($"Overwatch - {OverwatchCounter * 1.0 / soldGames * 100:F2}%");
            Console.WriteLine($"Others - {OthersCounter * 1.0 / soldGames * 100:F2}%");
        }
    }
}
