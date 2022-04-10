using System;

namespace _3.Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double singlePrice = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    singlePrice = 15;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 22.50;
                }
            }
            double price = count * singlePrice;
            if (count >= 30 && type == "Students")
            {
                price *= 0.85;
            }
            else if (count >= 100 && type == "Business")
            {
                count -= 10;
                price = count * singlePrice;
            }
            else if (count >= 10 && count <= 20 && type == "Regular")
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
