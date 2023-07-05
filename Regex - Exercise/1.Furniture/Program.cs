using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}$";
            string input;
            Regex regex = new Regex(pattern);
            double totalSum = 0;
            List<string> furnitureToPrint = new List<string>();

            while((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitureToPrint.Add(furnitureName);
                    totalSum += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            Console.WriteLine(String.Join(Environment.NewLine, furnitureToPrint));
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
