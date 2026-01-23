using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

// Project: CSE210 Week 02 Journal Program
// Author: Owen Jackson

// Exceeding requirements:
// I used a json file to store the journal
// I added a method that checks if a file exists to Journal.cs
// I added a method that confirms if the user wants to save the journal in Journal.cs

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.WriteLine();

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string date = "";
        string prompt = "";
        string entryText = "";
        string fileName = "";

        bool isJournaling = true;
        int userChoice;

        Console.WriteLine("Welcome to your journal.");

        do
        {
            userChoice = -1;

            do
            {
                Console.WriteLine("Choose one of these options:");
                Console.WriteLine(
                    "\t1.  Write"
                    + "\n\t2.  Display"
                    + "\n\t3.  Save"
                    + "\n\t4.  Load"
                    + "\n\t5.  Quit"
                );
                Console.Write("Enter 1-5: ");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (userChoice < 1 || userChoice > 5);

            if (userChoice == 1)
            {
                // (1A) Get journal entry from user
                prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt:\n{prompt}");
                Console.Write("Your response: ");
                entryText = Console.ReadLine();
                Console.WriteLine();

                // (1B) Create a new journal entry and add it to the journal
                Entry entry = new Entry();
                date = DateTime.Now.ToShortDateString();
                entry.Date = date;
                entry.PromptText = prompt;
                entry.EntryText = entryText;
                journal.AddEntry(entry);

                Console.WriteLine();
            }

            else if (userChoice == 2)
            {
                // (2) Display the journal
                journal.DisplayAll();

                Console.WriteLine();
            }

            else if (userChoice == 3)
            {
                // (3) Save journal to file
                Console.Write("What file would you like to save your journal to?: ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);

                Console.WriteLine();
            }

            else if (userChoice == 4)
            {
                // (4) Load the journal from file
                Console.Write("What file would you like to load your journal from?: ");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

                Console.WriteLine();
            }

            else
            {
                // (5) Quit
                isJournaling = false;
                Console.WriteLine("Closing Journal...");
            }

        } while (isJournaling);

        Console.WriteLine("Journal closed.\nThank you for using your journal today!\n");
    }
}