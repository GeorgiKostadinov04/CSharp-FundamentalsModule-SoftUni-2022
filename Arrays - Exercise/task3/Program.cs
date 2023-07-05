

namespace task3
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int number1 = numbers[0];
                int number2 = numbers[1];

                if (i % 2 == 1)
                {
                    arr1[i-1] = number1;
                    arr2[i - 1] = number2;
                }
                else
                {
                    arr1[i-1] = number2;
                    arr2[i-1] = number1;
                }
            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}
