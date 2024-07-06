using System;

namespace TextAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Text Analyzer App";
            Console.Clear();

            bool continueRunning = true;

            while (continueRunning)
            {
                DisplayHeader();

                Console.Write("Enter a text: ");
                string input = Console.ReadLine();

                int letterCount = CountLetters(input);
                int digitCount = CountDigits(input);

                DisplayResults(letterCount, digitCount);

                continueRunning = PromptToContinue();
                Console.Clear();
            }

            Console.WriteLine("Thank you for using the Text Analyzer. Goodbye!");
        }

        static void DisplayHeader()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("      Welcome to the Text Analyzer      ");
            Console.WriteLine("========================================");
            Console.WriteLine(Environment.NewLine);
        }

        static void DisplayResults(int letterCount, int digitCount)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("========================================");
            Console.WriteLine($" Letters Count: {letterCount}");
            Console.WriteLine($" Digits Count: {digitCount}");
            Console.WriteLine("========================================");
            Console.WriteLine(Environment.NewLine);
        }

        static bool PromptToContinue()
        {
            Console.Write("Do you want to analyze another text? (y/n): ");
            string response = Console.ReadLine().ToLower();

            return response == "y" || response == "yes";
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