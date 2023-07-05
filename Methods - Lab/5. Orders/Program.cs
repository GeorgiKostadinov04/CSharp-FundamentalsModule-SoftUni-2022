

namespace _5._Orders
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice = TotalSumCalculator(productType, quantity);
            Console.WriteLine($"{totalPrice:f2}");
        }


        static double TotalSumCalculator(string productType, int quantity)
        {
            if(productType == "water")
            {
                return quantity * 1;
            }
            else if(productType == "coffee")
            {
                return quantity * 1.50;
            }
            else if (productType == "coke")
            {
                return quantity * 1.40;
            }
            else
            {
                return quantity * 2;
            }
        }
    }
}
