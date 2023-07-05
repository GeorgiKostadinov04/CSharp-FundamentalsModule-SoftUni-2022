

namespace _5._Digits__Letters__and_Others
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (char chr in input)
            {
                if (char.IsDigit(chr))
                {
                    digits += chr;
                }
                else if (char.IsLetter(chr))
                {
                    letters += chr;
                }
                else
                {
                    others += chr;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
