using System;

namespace _6.Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine((ReturnMiddleCharacter(input)));
        }

        static string ReturnMiddleCharacter(string input)
        {
            int len = input.Length;
            string result = string.Empty;
            if (len % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            return result;
        }
    }
}