using System;

namespace _9.Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                int currentOdNumber = 1 + (i * 2);
                sum += currentOdNumber;
                Console.WriteLine(currentOdNumber);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
