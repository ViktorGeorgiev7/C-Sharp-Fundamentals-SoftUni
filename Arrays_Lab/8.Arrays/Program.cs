using System;
using System.Linq;

namespace _8.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstLenght = first.Length;
            for (int i = 0; i < firstLenght - 1; i++)
            {
                int[] condensed = new int[first.Length - 1];
                for (int j = 0; j < first.Length - 1; j++)
                {
                    condensed[j] = first[j] + first[j + 1];
                }
                first = condensed;
            }


            Console.WriteLine(first[0]);
        }
    }
}
