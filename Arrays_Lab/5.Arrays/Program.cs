using System;
using System.Linq;

namespace _5.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                int currentN = items[i];

                if (currentN % 2 == 0)
                {
                    sum += currentN;

                }

            }
            Console.WriteLine(sum);
        }
    }
}
