using System;
using System.Linq;

namespace _6.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                int currentN = items[i];

                if (currentN % 2 == 0)
                {
                    evenSum += currentN;

                }
                else
                {
                    oddSum += currentN;
                }

            }
            int difference = evenSum - oddSum;

            Console.WriteLine(difference);
        }
    }
}
