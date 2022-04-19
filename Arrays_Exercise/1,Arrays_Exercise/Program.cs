using System;

namespace _1_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];

            }
            Console.WriteLine(String.Join(' ', array));
            Console.WriteLine($"{sum}");
        }
    }
}
