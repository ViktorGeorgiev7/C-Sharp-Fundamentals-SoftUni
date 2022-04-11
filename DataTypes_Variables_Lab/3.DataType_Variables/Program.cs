using System;

namespace _3.DataType_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
