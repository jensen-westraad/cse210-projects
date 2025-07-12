using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date;

    public string _promptText;

    public string _entryText;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine(new string('-', 40)); 
    }

}