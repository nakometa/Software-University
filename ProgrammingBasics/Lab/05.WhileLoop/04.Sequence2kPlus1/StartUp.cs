using System;

namespace _04.Sequence2kPlus1
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            while (number <= n)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
