using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup scripture and reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.IsCompletelyHidden())
                break;

            scripture.HideRandomWords(3); 
        }

        Console.Clear();
        Console.WriteLine("Final Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job memorizing!");
    }
}