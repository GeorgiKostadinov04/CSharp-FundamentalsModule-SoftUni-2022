

namespace _4._Text_Filter
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach(string word in bannedWords)
            {
                if (text.Contains(word))
                {
                    string stringOfAsterisks = string.Empty;

                    for(int i = 0; i < word.Length; i++)
                    {
                        stringOfAsterisks += '*';
                    }
                    text = text.Replace(word, stringOfAsterisks);

                }
            }
            Console.WriteLine(text);
        }
    }
}
