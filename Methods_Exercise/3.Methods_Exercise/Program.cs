using System;

namespace _3.Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            CharBetweenTwoChars(firstSymbol, secondSymbol);
        }

        static void CharBetweenTwoChars(char first, char second)
        {
            int startChar = Math.Min(first, second);
            int endChar = Math.Max(first, second);

            for (int i = ++startChar; i < endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }

            Console.WriteLine();
        }
    }
}
