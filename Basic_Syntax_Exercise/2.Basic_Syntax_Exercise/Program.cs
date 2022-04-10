using System;

namespace _2.Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int divider = -1;

            if (number % 10 == 0)
            {
                divider = 10;
            }
            else if (number % 7 == 0)
            {
                divider = 7;
            }
            else if (number % 6 == 0)
            {
                divider = 6;
            }
            else if (number % 3 == 0)
            {
                divider = 3;
            }
            else if (number % 2 == 0)
            {
                divider = 2;
            }

            Console.WriteLine(divider == -1 ? "Not divisible" : $"The number is divisible by {divider}");
        }
    }
}
