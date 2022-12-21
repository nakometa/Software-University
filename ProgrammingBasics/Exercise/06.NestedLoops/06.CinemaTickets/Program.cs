using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string movie = input;
                int freeSeats = int.Parse(Console.ReadLine());
                int currentTickets = 0;

                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                    }
                    currentTickets++;
                }

                Console.WriteLine($"{movie} - {(currentTickets * 1.0 / freeSeats) * 100:F2}% full.");

                input = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets * 1.0 / totalTickets) * 100:F2}% student tickets.");
            Console.WriteLine($"{(standardTickets * 1.0 / totalTickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(kidTickets * 1.0 / totalTickets) * 100:F2}% kids tickets.");
        }
    }
}