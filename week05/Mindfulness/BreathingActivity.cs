using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int interval = 6; // seconds for each full breath in + out
        int cycles = duration / interval;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(3);

            Console.Write("Now breathe out... ");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}
