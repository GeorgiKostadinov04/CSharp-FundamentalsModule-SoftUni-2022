

namespace _6._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while(firstHand.Count != 0 && secondHand.Count != 0)
            {
                int i = 0;
                if (firstHand[i] > secondHand[i])
                {
                    firstHand.Add(secondHand[i]);
                    firstHand.Add(firstHand[i]);
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);

                }
                else if (firstHand[i] == secondHand[i])
                {
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);
                }
                else
                {
                    secondHand.Add(firstHand[i]);
                    secondHand.Add(secondHand[i]);
                    secondHand.RemoveAt(i);
                    firstHand.RemoveAt(i);
                }
                

            }
            if(firstHand.Count == 0)
            {
                Console.Write("Second player wins!");
                Console.WriteLine($" Sum: {secondHand.Sum()}");
            }
            else
            {
                Console.Write("First player wins!");
                Console.WriteLine($" Sum: {firstHand.Sum()}");
            }

        }
    }
}
