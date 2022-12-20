using System;

namespace _06.MaxNumber
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxValue = int.MinValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num > maxValue)
                {
                    maxValue = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxValue);
        }
    }
}
