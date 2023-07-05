

namespace _3.Substring
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string stringText = Console.ReadLine();

            while (stringText.Contains(specialWord))
            {
                int index = stringText.IndexOf(specialWord);
                stringText = stringText.Remove(index, specialWord.Length);
            }
            Console.WriteLine(stringText);
        }
    }
}
