

namespace _3._House_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string name = command[0];
                if(command.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for(int i = 0; i < guestList.Count; i++)
            {
                Console.Write(guestList[i]+ " ");
                Console.WriteLine();
            }
        }
    }
}
