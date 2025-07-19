using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup scripture and reference
        Reference reference = new Reference("1 Nephi", 3, 7);
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord has commended.";
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
        Console.WriteLine("Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job memorizing!");
    }
}