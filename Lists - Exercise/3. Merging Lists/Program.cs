

namespace _3._Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            List<int> mergedList = new List<int>();
            


            int n = Math.Min(numbers.Count, numbers2.Count);
            for (int i = 0; i < n; i++)
            {
                mergedList.Add(numbers[i]);
                mergedList.Add(numbers2[i]);
            }
            if(numbers.Count == numbers2.Count)
            {
                Console.WriteLine(String.Join(" ", mergedList));
                return;
            }

            if (numbers.Count > numbers2.Count)
            {
                for (int i = n; i < numbers.Count; i++)
                {
                    mergedList.Add(numbers[i]);
                }
            }
            else
            {
                for(int i = n; i < numbers2.Count; i++)
                {
                    mergedList.Add(numbers2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", mergedList));
        }
    }
}
