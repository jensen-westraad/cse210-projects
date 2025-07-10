using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>();



    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?",
            "What was one high and one low from today?",
            "What about today are you most proud of?"
        };

        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index];


    }
}