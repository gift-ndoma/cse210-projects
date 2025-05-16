using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save all entries to a file in CSV format
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    // Clean newlines and commas from fields for CSV format
                    string date = entry._date.Replace(",", " ");
                    string prompt = entry._promptText.Replace("\n", " ").Replace("\r", " ").Replace(",", " ");
                    string response = entry._entryText.Replace("\n", " ").Replace("\r", " ").Replace(",", " ");

                    // Write CSV line: date,prompt,response
                    writer.WriteLine($"{date},{prompt},{response}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Load entries from a file in CSV format
    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' not found.");
                return;
            }

            _entries.Clear();

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                // Split CSV line on commas
                string[] parts = line.Split(',');

                if (parts.Length >= 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
                else
                {
                    Console.WriteLine($"Skipped malformed line: {line}");
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
