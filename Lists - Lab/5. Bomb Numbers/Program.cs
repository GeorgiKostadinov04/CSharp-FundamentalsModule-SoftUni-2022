
using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < num.Count; i++)
            {
                if (bomb[0] == num[i])
                {
                    for (int r = i; r <= i + bomb[1]; r++)
                    {
                        if (r < num.Count)
                        {
                            num[r] = 0;
                        }
                    }
                    for (int r = i - 1; r >= i - bomb[1]; r--)
                    {
                        if (r >= 0)
                        {
                            num[r] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(num.Sum());
        }
    }
}
