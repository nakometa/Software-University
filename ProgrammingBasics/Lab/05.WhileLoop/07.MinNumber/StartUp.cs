using System;

namespace _07.MinNumber
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int number = int.Parse(input);
                
                if (number < minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
