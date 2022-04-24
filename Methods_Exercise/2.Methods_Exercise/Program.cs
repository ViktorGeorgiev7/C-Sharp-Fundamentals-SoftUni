using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowelsCount = PrintCountOfVowels(input);
            Console.WriteLine(vowelsCount);
        }
        static int PrintCountOfVowels(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;

            foreach (char symbol in input.ToLower())
            {
                if (vowels.Contains(symbol))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
