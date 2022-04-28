using System;
using System.Numerics;

namespace _2.Objects_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            //output

            Console.WriteLine(result);
        }
    }
}
