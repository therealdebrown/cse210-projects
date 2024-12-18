using System;

public abstract class Activity
{
    // Private fields shared by all activities
    private DateTime _date;
    private int _minutes;

    // Constructor for base class to initialize common properties
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public properties to access private fields
    public DateTime Date
    {
        get { return _date; }
    }

    public int Minutes
    {
        get { return _minutes; }
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method to generate a summary for the activity
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_minutes} min): " +
               $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F2} min per km";
    }
}
