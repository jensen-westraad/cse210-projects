public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        PromptGenerator generator = new PromptGenerator();
        string prompt = generator.GetRandomPrompt();

        newEntry._promptText = prompt;
        newEntry._date = DateTime.Now.ToShortDateString();

        Console.WriteLine("Today's prompt: " + newEntry._promptText);
        Console.Write("Your response: ");
        newEntry._entryText = Console.ReadLine();

        _entries.Add(newEntry);

        Console.WriteLine("Entry saved!\n");
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, append: true)) // appends journal.txt
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("==============================================================================");
            }
        }
        Console.WriteLine($"New Journal Entry saved to {file}\n");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine();
                string prompt = reader.ReadLine();
                string entryText = reader.ReadLine();
                reader.ReadLine();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = entryText;

                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal Entries loaded from {file}\n");
    }




}