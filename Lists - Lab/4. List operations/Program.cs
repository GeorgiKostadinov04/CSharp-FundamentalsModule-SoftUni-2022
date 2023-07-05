

namespace _4._List_operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] comnArgs = command.Split(' ');

                string commandType = comnArgs[0];

                if(commandType == "Add")
                {
                    int num = int.Parse(comnArgs[1]);
                    numbers.Add(num);
                }
                else if(commandType == "Insert")
                {
                    int num = int.Parse(comnArgs[1]);
                    int index = int.Parse(comnArgs[2]);
                    if(index <0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, num);
                }
                else if(commandType == "Remove")
                {
                    int index = int.Parse(comnArgs[1]);
                    if(index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if(commandType == "Shift")
                {
                    int count = int.Parse(comnArgs[2]);

                    if(comnArgs[1] == "left")
                    {
                         for(int i = 1; i <= count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int lenght = numbers.Count;
                            int lastNum = numbers[lenght-1];
                            numbers.RemoveAt(lenght-1);
                            numbers.Insert(0, lastNum);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
