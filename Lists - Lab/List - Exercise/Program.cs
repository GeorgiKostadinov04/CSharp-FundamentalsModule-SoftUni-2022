

namespace List___Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command;

            while((command = Console.ReadLine()) != "end")
            {
                string[] comnArgs = command.Split(' ');

                if(comnArgs.Length == 2)
                {
                    int number = int.Parse(comnArgs[1]);
                    wagons.Add(number);
                }
                else
                {
                    int people = int.Parse(comnArgs[0]);
                    for(int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + people <= maxCapacity)
                        {
                            wagons.Insert(i, wagons[i] + people);
                            wagons.RemoveAt(i+1);
                            break;
                           
                        }
                    }
                }

                
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
