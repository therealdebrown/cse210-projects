public class ChecklistGoal : Goal
{
    private int _target; 
    private int _amountCompleted; 
    private int _bonus; 

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