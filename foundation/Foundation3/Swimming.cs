using System;

public class Swimming : Activity
{
    // Private field specific to Swimming activity
    private int _laps;

    // Constructor for Swimming class
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes) // Call base class constructor
    {
        _laps = laps;
    }

    // Override method to calculate distance
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // Convert meters to kilometers
    }

    // Override method to calculate speed
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}
