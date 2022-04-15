using System;

namespace _4.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
