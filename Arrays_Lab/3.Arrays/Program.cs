using System;

namespace _3.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] items = new double[rawInput.Length];

            for (int i = 0; i < rawInput.Length; i++)
            {
                items[i] = double.Parse(rawInput[i]);
            }

            foreach (var t in items)
            {
                Console.WriteLine($"{t} => {Math.Round(t, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
