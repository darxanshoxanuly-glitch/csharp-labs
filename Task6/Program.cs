using System;

class Program
{
    static int CountWords(string text)
    {
        int wordCount = 0;
        bool inWord = false;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];

            if (currentChar != ' ' && currentChar != '\t')
            {
                if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return wordCount;
    }

    static void Main()
    {
        string? inputText;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            inputText = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(inputText));

        int wordsCount = CountWords(inputText);

        Console.WriteLine($"Бастапқы жол: \"{inputText}\"");
        Console.WriteLine($"Жолдағы сөздер саны = {wordsCount}");
    }
}
