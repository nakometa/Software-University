using System;

namespace _06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int totalPoints = 0;
            string bestPlayer = "";
            int mostPoints = int.MinValue;
            int counter = 0;

            while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    int currentPoints = 0;
                    char currentLetter = name[i];
                    if ((int)currentLetter == number)
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }
                    totalPoints += currentPoints;
                }
                counter++;
                if (totalPoints > mostPoints)
                {
                    mostPoints = totalPoints;
                    bestPlayer = name;
                }
                else if (totalPoints == mostPoints && counter >= 2)
                {
                    mostPoints = totalPoints;
                    bestPlayer = name;
                }
                totalPoints = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {bestPlayer} with {mostPoints} points!");
        }
    }
}
