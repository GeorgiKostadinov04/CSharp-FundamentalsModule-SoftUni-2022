
namespace _3._SofTUni_Bar_Income
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @"^[^\|\&\%\.]*?\%(?<customerName>[A-Z][a-z]+)\%[^\|\&\%\.]*?\<(?<productName>\w+)\>[^\|\&\%\.]*?\|(?<count>\d+)[^\|\&\%\.]*?\|[^\|\&\%\.]*?(?<price>\d+(\.\d+)?)\$$";
            Regex regex = new Regex(pattern);
            double totalSum = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName = match.Groups["customerName"].Value;
                    string productName = match.Groups["productName"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalSum += totalPrice;

                    Console.WriteLine($"{customerName}: {productName} - {totalPrice:f2}");
                }
                
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
