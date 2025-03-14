using System.IO;
using System.Reflection;
public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine("\nMy journal");
        Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
                outputFile.WriteLine(entry.FormatForFileSave());
        }
        System.Console.WriteLine("\nJournal Saved!");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._time = parts[1];
            entry._entryType = parts[2];
            
            // Replace commas with dashes to prevent issues in the CSV file
            entry._promptOrTitleText = parts[3].Replace("-",",");
            entry._entryText = parts[4].Replace("-",",");

            _entries.Add(entry);
        }

        Display();
    }
}