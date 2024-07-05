using System;

namespace TextAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Text Analyzer App";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("      Welcome to the Text Analyzer      ");
            Console.WriteLine("========================================");
            Console.WriteLine(Environment.NewLine);

            Console.Write("Enter a text: ");
            string input = Console.ReadLine();

            int letterCount = CountLetters(input);
            int digitCount = CountDigits(input);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("========================================");
            Console.WriteLine($" Letters Count: {letterCount}");
            Console.WriteLine($" Digits Count: {digitCount}");
            Console.WriteLine("========================================");

            Console.ResetColor();
        }

        static int CountLetters(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountDigits(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
