using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _1._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<name>([A-Za-z||\-||\.||_]+))\@((?<host>[A-Za-z||\-])\.?)+\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            List<string> list = new List<string>();
            foreach (Match match in matchCollection)
            {
                list.Add(match.Value);
            }

            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }
}
