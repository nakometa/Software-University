﻿using System;

namespace _04.InchesToCentimeters
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double inchToCentimeter = num * inch;

            Console.WriteLine(inchToCentimeter);
        }
    }
}
