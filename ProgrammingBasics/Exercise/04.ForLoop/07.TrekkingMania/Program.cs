using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleClimbingMusala = 0;
            int peopleClimbingMonblan = 0;
            int peopleClimbingKilimandjaro = 0;
            int peopleClimbingK2 = 0;
            int peopleClimbingEverest = 0;
            int totalClimbers = 0;

            int people = int.Parse(Console.ReadLine());

            for (int i = 0; i < people; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                if (climbers <= 5)
                {
                    peopleClimbingMusala += climbers;
                }
                else if (climbers > 5 && climbers <= 12)
                {
                    peopleClimbingMonblan += climbers;
                }
                else if (climbers > 12 && climbers <= 25)
                {
                    peopleClimbingKilimandjaro += climbers;
                }
                else if (climbers > 25 && climbers <= 40)
                {
                    peopleClimbingK2 += climbers;
                }
                else
                {
                    peopleClimbingEverest += climbers;
                }

                totalClimbers += climbers;
            }

            Console.WriteLine($"{(peopleClimbingMusala * 1.0 / totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(peopleClimbingMonblan * 1.0 / totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(peopleClimbingKilimandjaro * 1.0 / totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(peopleClimbingK2 * 1.0 / totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(peopleClimbingEverest * 1.0 / totalClimbers) * 100:F2}%");
        }
    }
}