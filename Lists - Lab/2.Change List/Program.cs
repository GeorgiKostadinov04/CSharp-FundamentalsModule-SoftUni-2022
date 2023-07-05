

namespace _2.Change_List
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

            string command;

            while((command = Console.ReadLine()) != "end")
            {
                string[] comnArgs = command.Split(' ');

                string commandType = comnArgs[0];

                if(commandType == "Delete")
                {
                    int element = int.Parse(comnArgs[1]);
                    numbers.RemoveAll(x => x == element);
                    
                }
                else if(commandType == "Insert")
                {
                    int element = int.Parse(comnArgs[1]);
                    int position = int.Parse(comnArgs[2]);

                    numbers.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
