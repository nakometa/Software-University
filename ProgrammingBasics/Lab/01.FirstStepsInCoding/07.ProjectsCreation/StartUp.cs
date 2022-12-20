using System;

namespace _07.ProjectsCreation
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());
            int projectHours = projectsNumber * 3;

            Console.WriteLine($"The architect {architectName} will need {projectHours} hours to complete {projectsNumber} project/s.");
        }
    }
}
