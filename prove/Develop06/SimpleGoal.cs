public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true; // Mark the goal as complete
        Console.WriteLine($"'{_name}' completed! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_name}: {_description} ({_points} points) - {(IsComplete() ? "Completed" : "Incomplete")}";
    }
}