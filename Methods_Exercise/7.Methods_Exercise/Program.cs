﻿using System;

namespace _7.Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numbers = PrintNumber(number);
        }
        static int PrintNumber(int numbers)
        {
            for (int row = 1; row <= numbers; row++)
            {
                for (int cell = 1; cell <= numbers; cell++)
                {
                    Console.Write($"{numbers} ");
                }
                Console.WriteLine();
            }
            return numbers;
        }
    }
}