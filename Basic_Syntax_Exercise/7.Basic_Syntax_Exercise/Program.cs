using System;

namespace _7.Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const double nuts = 2.00;
            const double water = 0.7;
            const double crisps = 1.5;
            const double soda = 0.8;
            const double coke = 1.0;

            static void Main(string[] args)
            {

                string input = string.Empty;
                string product = string.Empty;
                double coinSum = 0;

                while ((input = Console.ReadLine()) != "Start")
                {
                    double coins = double.Parse(input);

                    if (coins == 0.10 || coins == 0.20 || coins == 0.50 || coins == 1.00 || coins == 2.00)

                    {
                        coinSum += coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }
                }

                while ((product = Console.ReadLine()) != "End")
                {
                    if (product == "Nuts")
                    {
                        if (coinSum < nuts)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            continue;
                        }

                        coinSum -= nuts;
                        Console.WriteLine($"Purchased {product.ToLower()}");

                    }
                    else if (product == "Water")
                    {
                        if (coinSum < water)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            continue;
                        }

                        coinSum -= water;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Crisps")
                    {

                        if (coinSum < crisps)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            continue;
                        }

                        coinSum -= crisps;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Soda")
                    {
                        if (coinSum < soda)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            continue;
                        }

                        coinSum -= soda;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Coke")
                    {

                        if (coinSum < coke)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            continue;
                        }

                        coinSum -= coke;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }

                Console.WriteLine($"Change: {coinSum:f2}");
            }
        }
    }
}
