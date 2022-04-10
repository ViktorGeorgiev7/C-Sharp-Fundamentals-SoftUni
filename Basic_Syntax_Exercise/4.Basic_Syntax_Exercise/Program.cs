using System;

namespace _4.Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int num = int.Parse(Console.ReadLine());
            int currenNumber = 0;
            for (int i = number; i <= num; i++)
            {
                currenNumber += i;

                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {currenNumber}");
        }
    }
}
