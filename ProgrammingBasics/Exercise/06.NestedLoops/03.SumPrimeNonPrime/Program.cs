using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int counter = 0;
                int currentNum = int.Parse(input);
                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 2; i <= currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    nonPrimeSum += currentNum;
                }
                else
                {
                    primeSum += currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
