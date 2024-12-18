using System;

public class Running : Activity
{
    // Private field specific to Running activity
    private double _distance;

    // Constructor for Running class
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes) // Call base class constructor
    {
        _distance = distance;
    }

    // Override method to calculate distance (already known here)
    public override double GetDistance()
    {
        return _distance;
    }

    // Override method to calculate speed
    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return Minutes / _distance;
    }
}
