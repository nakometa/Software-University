using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededPoints = 1250.5;

            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());

            for (int i = 0; i < evaluators; i++)
            {
                string evaluator = Console.ReadLine();
                double evaluatorPoints = double.Parse(Console.ReadLine());

                academyPoints += (evaluator.Length * evaluatorPoints) / 2;

                if (academyPoints > neededPoints)
                {
                    break;
                }
            }

            if (academyPoints < neededPoints)
            {
                Console.WriteLine($"Sorry, {actor} you need {neededPoints - academyPoints:F1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyPoints:F1}!");
            }
        }
    }
}
