public class ChecklistGoal : Goal
{
    private int _target; // Number of steps to complete the goal
    private int _amountCompleted; // Steps completed
    private int _bonus; // Bonus points when the goal is fully completed

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"'{_name}' progress updated! Step {_amountCompleted}/{_target} completed.");

        if (IsComplete())
        {
            Console.WriteLine($"Goal completed! Bonus {_bonus} points awarded.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_name}: {_description} ({_points} points) - Completed: {_amountCompleted}/{_target}";
    }
}