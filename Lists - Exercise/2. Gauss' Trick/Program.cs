﻿

namespace _2._Gauss__Trick
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
            List<int> numbers2 = new List<int>();
            int countN = numbers.Count-1;

            if(numbers.Count % 2 == 0)
            {
                for(int i = 0; i < numbers.Count/2; i++)
                {

                    int sum = numbers[0 + i] + numbers[countN - i];
                    numbers2.Add(sum);
                    sum = 0;
                }
            }
            else
            {
                for(int j = 0; j < numbers.Count/2; j++)
                {
                    int sum = numbers[0 + j] + numbers[countN - j];
                    numbers2.Add(sum);
                    sum = 0;
                    
                }
                numbers2.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(" ",numbers2));
        }
    }
}
