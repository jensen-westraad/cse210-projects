using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true; // for my loop

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice) //https://www.youtube.com/watch?v=Qu93CRt-FGc // video I used to better understand switches as a alternative conditional statement for a cleaner looking program.
            {
                case "1":
                    Entry entry = new Entry();
                    myJournal.AddEntry(entry);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Good job on writing in your journal. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1–5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}