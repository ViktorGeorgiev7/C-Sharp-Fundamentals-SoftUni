using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> list = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    Console.Write($"{list[j]} ");
                }
            }
        }
    }
}
