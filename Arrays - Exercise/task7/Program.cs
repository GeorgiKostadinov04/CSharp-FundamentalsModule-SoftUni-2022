

namespace task7
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
            int longestSequence = 1;
            int numberWithLongestSequence = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                int counter = 1;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(currNum == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(counter > longestSequence)
                {
                    longestSequence = counter;
                    numberWithLongestSequence = currNum;
                }
            }

            for(int k = 1; k <= longestSequence; k++)
            {
                Console.Write(numberWithLongestSequence+ " ");
            }
        }
    }
}
