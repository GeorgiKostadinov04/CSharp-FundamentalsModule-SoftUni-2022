

namespace task7
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int totalSum = 0;

            for(int i = 0; i < arr1.Length; i++)
            {
                int currNum1 = arr1[i];
                int currNum2 = arr2[i];

                if(currNum1 != currNum2)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                totalSum += arr1[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            
        }
    }
}
