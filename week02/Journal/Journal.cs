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
        Console.WriteLine("Today's prompt: " + newEntry._promptText);
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }




}