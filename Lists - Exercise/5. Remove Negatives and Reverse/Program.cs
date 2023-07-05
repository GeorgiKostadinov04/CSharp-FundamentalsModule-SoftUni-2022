

namespace _5._Remove_Negatives_and_Reverse
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

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            List<int> numbersReversed = new List<int>();
            for(int i = numbers.Count-1; i >=0; i--)
            {
                int currNum = numbers[i];
                numbersReversed.Add(currNum);

            }
            if(numbersReversed.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbersReversed));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
