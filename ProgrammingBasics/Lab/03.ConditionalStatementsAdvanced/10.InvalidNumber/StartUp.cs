using System;

namespace _10.InvalidNumber
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200)
            {

            }
            else if (number == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
