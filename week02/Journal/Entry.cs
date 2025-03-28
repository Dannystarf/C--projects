using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{Date} - {PromptText}\n{EntryText}");
    }

    public string ToCsv()
    {
        string safeDate = Date ?? string.Empty;
        string safePromptText = PromptText ?? string.Empty;
        string safeEntryText = EntryText ?? string.Empty;

        return $"\"{safeDate}\",\"{safePromptText.Replace("\"", "\"\"")}\",\"{safeEntryText.Replace("\"", "\"\"")}\"";
    }
}