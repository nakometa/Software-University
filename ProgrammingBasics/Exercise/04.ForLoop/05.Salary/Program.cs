using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int facebookTabPrice = 150;
            const int instagramTabPrice = 100;
            const int redditTabPrice = 50;
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string tabName = Console.ReadLine();

                if (tabName == "Facebook")
                {
                    salary -= facebookTabPrice;
                }
                else if (tabName == "Instagram")
                {
                    salary -= instagramTabPrice;
                }
                else if (tabName == "Reddit")
                {
                    salary -= redditTabPrice;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
