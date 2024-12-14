public class GoalManager
{
    private List<Goal> _goals;
    private LevelTracker _levelTracker;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _levelTracker = new LevelTracker();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many steps are required to complete this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case 4:
                _goals.Add(new NegativeGoal(name, description, -points)); 
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\n--- Goals ---");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void RecordEvent()
        {
        Console.Write("Which goal did you accomplish? ");
        string goalName = Console.ReadLine();

        Goal goal = _goals.Find(g => g.GetDetailsString().Contains(goalName));

        if (goal != null)
        {
            goal.RecordEvent();

            if (goal is NegativeGoal)
                _levelTracker.DeductPoints(goal._points);
            else
                _levelTracker.AddPoints(goal._points);
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayLevelInfo()
    {
        _levelTracker.DisplayLevel();
    }
}