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
        int interval = 10; // seconds for each full breath (in + out)
        int cycles = duration / interval;
        int remainder = duration % interval;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.Write("Now breathe out... ");
            ShowCountDown(6);
        }

        // Handle remaining seconds with a shorter final breath cycle
        if (remainder > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Finishing strong with a last breath...");

            int inhaleDuration = remainder / 2;
            int exhaleDuration = remainder - inhaleDuration;

            Console.Write("Breathe in... ");
            ShowCountDown(inhaleDuration);

            Console.Write("Now breathe out... ");
            ShowCountDown(exhaleDuration);
        }

        DisplayEndingMessage();
    }

}
