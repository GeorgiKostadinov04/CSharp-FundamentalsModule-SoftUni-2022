

namespace task2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            for(int i = 0; i < arr2.Length; i++)
            {
                string currChar = arr2[i];
                for(int j = 0; j < arr1.Length; j++)
                {
                    string currChar2 = arr1[j];
                    if(currChar2 == currChar)
                    {
                        Console.Write(currChar + " ");
                        break;
                    }
                }
                
            }
        }
    }
}
