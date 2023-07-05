

namespace _2._Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<letters>[A-Za-z])";
            string pattern2 = @"(?<digits>\d)";
            Regex letters = new Regex(pattern);
            Regex digits = new Regex(pattern2);
            string[] names = Console.ReadLine().Split(", ");
            string input;
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "end of race")
            {
                int sum = 0;
                string nameOfPlayer = string.Empty;
                foreach (Match match1 in letters.Matches(input))
                {
                    if (match1.Success)
                    {
                        nameOfPlayer += match1.Value.ToString();
                    }
                }
                if (names.Contains(nameOfPlayer))
                {
                    foreach (Match match in digits.Matches(input))
                    {

                        if (match.Success)
                        {
                            int digit = int.Parse(match.Value);
                            sum += digit;
                        }
                    }
                }
                else
                {
                    continue;
                }
                
               
                if (keyValuePairs.ContainsKey(nameOfPlayer))
                {
                    keyValuePairs[nameOfPlayer] += sum;
                    continue;
                    
                }
                if (names.Contains(nameOfPlayer))
                {
                    keyValuePairs.Add(nameOfPlayer, sum);
                }



            }
            string[] bestRacers = keyValuePairs.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToArray();


           
            
            Console.WriteLine($"1st place: {bestRacers[0]}");

            Console.WriteLine($"2nd place: {bestRacers[1]}");

            Console.WriteLine($"3rd place: {bestRacers[2]}");
            
            

        }

        
    }
}
