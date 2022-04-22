using System;

namespace _6.Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double area = RectangleArea(a, b);
            Console.WriteLine(area);
        }

        static double RectangleArea(double height, double width)
        {
            return width * height;
        }
    }
}
