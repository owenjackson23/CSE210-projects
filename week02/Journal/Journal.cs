using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // TODO: Implement method to display all journal entries
    }

    public void SaveToFile(string filename)
    {
        // TODO: Implement method to save journal entries to a file
    }

    public void LoadFromFile(string filename)
    {
        // TODO: Implement method to load journal entries from a file
    }
}