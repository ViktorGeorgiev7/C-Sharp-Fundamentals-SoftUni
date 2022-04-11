using System;

namespace _1.DataType_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());
            string empty = string.Empty;
            double kilo = meters / 1000;
            if (kilo < 0)
            {
                Console.WriteLine(empty);
            }
            else
            {
                Console.WriteLine($"{Math.Round(kilo, 2, MidpointRounding.AwayFromZero):f2}");
            }
        }
    }
}
