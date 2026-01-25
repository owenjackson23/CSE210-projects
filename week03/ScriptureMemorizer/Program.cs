using System;

// Project: CSE210 Week 03 Scripture Memorizer Program
// Author: Owen Jackson

// Exceeding requirements:
// Only words that are not already hidden are randomly selected
// Punctuation and special characters won't be hidden

class Program
{
    static void Main(string[] args)
    {
        string book;
        int chapter;
        int verse;
        int endVerse;
        string text;

        // Create scripture object and save display text to string
        book = "Proverbs";
        chapter = 3;
        verse = 5;
        endVerse = 6;
        text = "Trust in the Lord with all thine heart; "
        + "and lean not unto thine own understanding. "
        + "In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference refProverbs356 = new Reference(book, chapter, verse, endVerse);
        Scripture proverbs356 = new Scripture(refProverbs356, text);
        string scriptureText = proverbs356.GetDisplayText();

        // Display scripture
        Console.Clear();
        Console.WriteLine(scriptureText);

        string userInput;
        do
        {
            userInput = "";

            // Prompt user to continue or quit
            Console.Write("\nPress 'enter' to continue, or enter 'quit': ");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "quit")
            {
                break;
            }
            else
            {
                proverbs356.HideRandomWords(3);
            }

            scriptureText = proverbs356.GetDisplayText();

            // Display updated scripture
            Console.Clear();
            Console.WriteLine(scriptureText);

        } while (userInput != "quit" && !proverbs356.IsCompletelyHidden());

        Console.WriteLine("\nGoodbye");
    }
}