using System;

namespace _1.Objects_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);

                (input[i], input[randomIndex]) = (input[randomIndex], input[i]);
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
