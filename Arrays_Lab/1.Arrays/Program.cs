using System;

namespace _1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var days = new[] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Console.WriteLine(n is >= 1 and <= 7 ? $"{days[n - 1]}" : "Invalid day!");
        }
    }
}
