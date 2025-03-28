using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile (string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Entry");
            
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0].Trim('"'), parts[1].Trim('"'), parts[2].Trim('"')));
                }
            }
        }
    }

    public void SearchEntries(string keyword)
    {
        foreach (var entry in _entries)
        {
            if (entry.EntryText.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                entry.PromptText.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                entry.Display();
            }
        }
    }
}