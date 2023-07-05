

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

            for(int i = 0; i < numbers.Length-1; i++)
            {
                int currNum = numbers[i];
                for(int j = i+1; j < numbers.Length; j++)
                {
                    if(currNum > numbers[j])
                    {
                        if(j == numbers.Length - 1)
                        {
                            Console.Write(currNum + " ");
                        }
                    }
                    else
                    {
                        break;
                    }  
                }
                
            }
            Console.Write(numbers[numbers.Length-1]);
        }
    }
}
