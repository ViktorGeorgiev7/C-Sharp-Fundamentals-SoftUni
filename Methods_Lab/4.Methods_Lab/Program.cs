using System;

namespace _4.Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                Triangle(1, i);
            }
            for (int i = height - 1; i >= 1; i--)
            {
                Triangle(1, i);

            }
        }

        static void Triangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
