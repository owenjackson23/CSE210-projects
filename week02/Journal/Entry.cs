using System;

public class Entry
{
    // Does not work as fields, so I changed to properties
    // Properties use get and set to access and change the value,
    // and fields don't
    public string Date { get; set; } = "";
    public string PromptText { get; set; } = "";
    public string EntryText { get; set; } = "";

    public void Display()
    {
        Console.WriteLine(Date);
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"\n{EntryText}");
        Console.WriteLine();
    }
}