
using System;

class Program
{
    static void Main()
    {
        string text;

        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Бос жол! Қайта енгізіңіз.");
            }

        } while (string.IsNullOrWhiteSpace(text));

        int count = CountWords(text);

        Console.WriteLine();
        Console.WriteLine("Бастапқы жол: " + text);
        Console.WriteLine("Сөздер саны = " + count);
    }

    static int CountWords(string text)
    {
        int count = 0;
        bool insideWord = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsWhiteSpace(text[i]))
            {
                insideWord = false;
            }
            else if (!insideWord)
            {
                count++;
                insideWord = true;
            }
        }

        return count;
    }
}