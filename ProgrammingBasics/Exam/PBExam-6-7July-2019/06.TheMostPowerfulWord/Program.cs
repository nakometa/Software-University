using System;

namespace _06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string mostPowerfulWord = "";
            double bestWordValue = double.MinValue;

            while (word != "End of words")
            {
                double currentSum = 0;
                for (int i = 0; i < word.Length; i++)
                {

                    char currentLetter = word[i];
                    currentSum += (int)currentLetter;

                }
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    currentSum = currentSum * word.Length;
                }
                else
                {
                    currentSum = Math.Floor(currentSum / word.Length);
                }
                if (currentSum > bestWordValue)
                {
                    bestWordValue = currentSum;
                    mostPowerfulWord = word;
                }
                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {bestWordValue}");
        }
    }
}
