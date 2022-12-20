using System;

namespace _05.CharacterSequence
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                Console.WriteLine(currentChar);
            }
        }
    }
}
