using System;

namespace _02.NumbersNTo1
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
