

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
            List<int> numbersCopy = numbers.ToList();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] comnArgs = command.Split(' ')
                    .ToArray();

                string commandType = comnArgs[0];

                if (commandType == "Add")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.Add(num);
                }
                else if (commandType == "Remove")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.Remove(num);
                }
                else if (commandType == "RemoveAt")
                {
                    int num = ReturnNum(comnArgs);
                    numbers.RemoveAt(num);
                }
                else if (commandType == "Insert")
                {
                    int num = ReturnNum(comnArgs);
                    int index = int.Parse(comnArgs[2]);
                    numbers.Insert(index, num);
                }
                else if(commandType == "Contains")
                {
                    int num = ReturnNum(comnArgs);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if(commandType == "PrintEven")
                {
                    
                    for (int i = 0; i < numbers.Count; i++)
                    { 
                        int currNum = numbers[i];
                        if(currNum % 2 == 0)
                        {
                            Console.Write(currNum+ " ");
                        }
                    }
                    Console.WriteLine();
                    
                }
                else if( commandType == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currNum = numbers[i];
                        if (currNum % 2 == 1)
                        {
                            Console.Write(currNum + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(commandType == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if(commandType == "Filter")
                {
                    string condition = comnArgs[1];
                    int num = int.Parse(comnArgs[2]);

                    List<int> filterNumber = FilterMethod(condition,num,numbers);
                    for(int i = 0; i < filterNumber.Count; i++)
                    {
                        int currNum = filterNumber[i];
                        Console.Write(currNum+ " ");
                    }
                    Console.WriteLine();
                }

            }
           if(numbers.Count == numbers.Count)
            {
                for(int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] != numbersCopy[i])
                    {
                        for(i = 0; i < numbers.Count; i++)
                        {
                            int currNum = numbers[i];
                            Console.Write(currNum+ " ");
                        }
                    }
                }
            }
            
        }

        static int ReturnNum(string[] command)
        {
            int number = int.Parse(command[1]);
            return number;
        }
        static List<int> FilterMethod(string condition, int number, List<int> numbers)
        {
            List<int> result = new List<int>();
            if(condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int currNum = numbers[i];
                    if (currNum < number)
                    {
                        result.Add(currNum);
                    }
                }
            }
            else if(condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int currNum = numbers[i];
                    if (currNum > number)
                    {
                        result.Add(currNum);
                    }
                }
            }
            else if(condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int currNum = numbers[i];
                    if (currNum >= number)
                    {
                        result.Add(currNum);
                    }
                }
            }
            else if(condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int currNum = numbers[i];
                    if (currNum <= number)
                    {
                        result.Add(currNum);
                    }
                }
            }
            return result;
        }
    }
}
