using System;

namespace _7.Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(template, repeat));
        }

        static string RepeatString(string template, int repeats)
        {
            string result = string.Empty;
            for (int i = 0; i < repeats; i++)
            {
                result += template;
            }
            return result;
        }
    }
}
