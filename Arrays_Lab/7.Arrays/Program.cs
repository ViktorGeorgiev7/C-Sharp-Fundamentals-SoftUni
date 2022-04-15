using System;
using System.Linq;

namespace _7.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            bool identical = false;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;


                }


                if (first[i] == second[i])
                {
                    sum += first[i];
                    identical = true;
                }

            }
            if (identical == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }


        }
    }
}
