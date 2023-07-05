

namespace _9._Greater_of_Two_Values
{
    using System;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string variableType = Console.ReadLine();

            if(variableType == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int finalResult = GetMax(n1, n2);
                Console.WriteLine(finalResult);
            }
            else if(variableType == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char finalResult = GetMax(char1, char2);
                Console.WriteLine(finalResult);
            }
            else if(variableType == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string finalResult = GetMax(str1, str2);
                Console.WriteLine(finalResult);
            }
        }

        static int GetMax(int n1,int n2)
        {
            if(n1 > n2)
            {
                return n1;
            }
            return n2;
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }

        static string GetMax(string str1, string str2)
        {
            int result = String.Compare(str1, str2);

            if(result == 1)
            {
                return str1;
            }
            return str2;

        }
    }
}
