using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Your journal:\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        Console.Write("Press 'Enter' to continue ");
        Console.ReadLine();
    }

    public void SaveToFile(string filename)
    {
        bool doSave = false;
        doSave = SaveWarning();

        if (doSave)
        {
            //filename = CheckFileName(filename);

            // Convert entries to JSON text
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(_entries, options);

            // Save to file
            File.WriteAllText(filename, json);

            Console.WriteLine($"Journal saved to '{filename}'");
        }

        else
        {
            Console.WriteLine("Save cancelled");
        }
    }

    public void LoadFromFile(string filename)
    {
        filename = CheckFileName(filename);

        // Read the JSON file
        string json = File.ReadAllText(filename);

        // Convert JSON to a list
        List<Entry> _previousEntries = JsonSerializer.Deserialize<List<Entry>>(json);

        if (_previousEntries != null)
        {
            // Add list to _entries list
            foreach (Entry entry in _previousEntries)
            {
                _entries.Add(entry);
            }

            Console.WriteLine($"Successfully loaded journal from '{filename}'");
        }
        else
        {
            Console.WriteLine($"{filename} is empty, so nothing was loaded");
        }
    }

    private string CheckFileName(string filename)
    {
        while (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' could not be found.");
            Console.Write("Enter a valid file name: ");
            filename = Console.ReadLine();
        }
        return filename;
    }

    private bool SaveWarning()
    {
        bool doSave = false;
        string input = "";

        Console.WriteLine("Saving will overwrite the current file.");
        Console.Write("Do you wish to continue? (y/n): ");
        input = Console.ReadLine();

        while (input != "y" && input != "n")
        {
            Console.WriteLine("ERROR: Invalid Input");
            Console.Write("Enter 'y' or 'n': ");
            input = Console.ReadLine();
        }

        if (input == "y")
        {
            doSave = true;
        }
        else
        {
            doSave = false;
        }

        return doSave;
    }
}