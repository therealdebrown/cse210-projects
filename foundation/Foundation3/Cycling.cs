using System;

public class Cycling : Activity
{
    // Private field specific to Cycling activity
    private double _speed;

    // Constructor for Cycling class
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes) // Call base class constructor
    {
        _speed = speed;
    }

    // Override method to calculate distance using speed
    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    // Override method to return speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
