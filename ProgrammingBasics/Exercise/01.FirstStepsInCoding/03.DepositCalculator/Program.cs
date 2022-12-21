using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double yearInterest = deposit * (interestRate / 100);
            double monthInterest = yearInterest / 12;
            double total = deposit + (monthInterest * months);

            Console.WriteLine(total);
        }
    }
}
