
namespace task5
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int totalSumEven = 0;
            int totalSumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    totalSumEven += numbers[i];
                }
                else
                {
                    totalSumOdd +=numbers[i];
                }
            }
            int result = totalSumEven - totalSumOdd;
            Console.WriteLine(result);


        }
    }
}
