

namespace _6._List_Manipulation_Basics
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

            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] comnArgs = command.Split(' ')
                    .ToArray();

                string commandType = comnArgs[0];

                if(commandType == "Add")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.Add(num);
                }
                else if(commandType == "Remove")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.Remove(num);
                }
                else if(commandType == "RemoveAt")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.RemoveAt(num);
                }
                else if(commandType == "Insert")
                {
                    int num = ReturnNum(comnArgs);
                    int index = int.Parse(comnArgs[2]);
                    numbers.Insert(index, num);
                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }

        static int ReturnNum( string[] command)
        {
            int number = int.Parse(command[1]);
                return number;
        }
    }
}
