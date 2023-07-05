

namespace task7
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();
            double totalCoin = 0.0;

            while(output != "Start")
            {
                double coin = double.Parse(output);
                if (coin != 0.1 && coin != 0.2 && coin !=0.5 && coin !=1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    totalCoin += coin;
                }
                output = Console.ReadLine();

            }
            string product = Console.ReadLine();
            while(product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if(totalCoin >= 2)
                        {
                            Console.WriteLine($"Purchased nuts");
                            totalCoin -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalCoin >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            totalCoin -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalCoin >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            totalCoin -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalCoin >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            totalCoin -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalCoin >= 1)
                        {
                            Console.WriteLine($"Purchased coke");
                            totalCoin -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoin:f2}");

        }
    }
}
