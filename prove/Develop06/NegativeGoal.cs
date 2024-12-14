public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Warning: '{_name}' occurred! You lost {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Negative goals never complete
    }

    public override string GetDetailsString()
    {
        return $"{_name}: {_description} ({_points} points penalty)";
    }
}