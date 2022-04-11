using System;

namespace _2.DataType_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal usd = pound * 1.31M;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
