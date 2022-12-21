using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());

            int totalFreeSpace = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            int spaceTaken = 0;
            bool isFull = false;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                
                if (totalFreeSpace < spaceTaken + boxes)
                {
                    isFull = true;
                    Console.WriteLine($"No more free space! You need {(spaceTaken + boxes) - totalFreeSpace} Cubic meters more.");
                    break;
                }

                spaceTaken += boxes;

                input = Console.ReadLine();
            }

            if (!isFull)
            {
                Console.WriteLine($"{totalFreeSpace - spaceTaken} Cubic meters left.");
            }
        }
    }
}
