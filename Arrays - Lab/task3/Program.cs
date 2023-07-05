

namespace task3
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            int[] roundedNums = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundedNums[i]}");
            }
        }
    }
}
