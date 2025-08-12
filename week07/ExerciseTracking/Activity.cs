using System;

abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Minutes
    {
        get { return _minutes; }
        set { _minutes = value; }
    }

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // kph
    public abstract double GetPace();     // min per km

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - " +
               $"Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}