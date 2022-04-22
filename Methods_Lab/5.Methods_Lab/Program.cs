using System;

namespace _5.Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Orders(product, quantity);
        }

        static void Orders(string product, double quantity)
        {
            double sum = 0;
            double price;
            
            switch (product)
            {
                case "water":
                    price = 1.00;
                    sum = quantity * price;
                    break;
                case "coffee":
                    price = 1.50;
                    sum = quantity * price;
                    break;
                case "coke":
                    price = 1.40;
                    sum = quantity * price;
                    break;
                case "snacks":
                    price = 2.00;
                    sum = quantity * price;
                    break;
            }
            Console.WriteLine($"{sum:f2}");
            
        }
    }
}
