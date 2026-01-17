using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.WriteLine();

        // Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string date = "";
        string prompt = "";
        string entryText = "";

        // Get journal entry from user
        prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt:\n{prompt}: ");
        Console.Write("Your response: ");
        entryText = Console.ReadLine();
        Console.WriteLine();

        // Create a new journal entry
        Entry entry = new Entry();
        date = DateTime.Now.ToShortDateString();
        entry._date = date;
        entry._promptText = prompt;
        entry._entryText = entryText;
        // journal.AddEntry(entry);
        entry.Display();
    }
}