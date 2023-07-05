

namespace task6
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
            

            for(int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                if (i < numbers.Length)
                {
                    for(int j = i+1; j < numbers.Length; j++)
                    {
                        rightSum +=numbers[j];
                    }
                }
                if(i > 0)
                {
                    for (int k = i-1 ; k >= 0; k--)
                    {
                        leftSum += numbers[k];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                } 
            }
            Console.WriteLine("no");
            
        }
    }
}
