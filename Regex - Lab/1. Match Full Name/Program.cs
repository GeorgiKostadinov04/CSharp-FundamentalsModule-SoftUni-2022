﻿

namespace _1._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach(Match match in matchCollection)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
