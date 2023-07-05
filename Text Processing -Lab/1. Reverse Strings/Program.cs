

namespace _1._Reverse_Strings
{
    using System;
    using System.Text;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string currWordReversed = string.Empty;

                for(int i = input.Length-1; i >= 0; i--)
                {
                    currWordReversed += input[i]; 
                }
                Console.WriteLine($"{input} = {currWordReversed}");
            }

        }
    }
}
