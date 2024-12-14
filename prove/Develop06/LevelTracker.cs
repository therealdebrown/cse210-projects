public class LevelTracker
{
    private int _totalPoints;
    private int _level;

    public LevelTracker()
    {
        _totalPoints = 0;
        _level = 1;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        Console.WriteLine($"Points updated: {_totalPoints} points.");

            // Check if the user levels up
        if (_totalPoints >= _level * 100)
        {
            _level++;
            Console.WriteLine($"Congratulations! You reached Level {_level}!");
        }
    }

    public void DeductPoints(int points)
    {
        _totalPoints -= points;
        if (_totalPoints < 0) _totalPoints = 0; // Ensure points don't go below zero
        Console.WriteLine($"Points deducted: {_totalPoints} points.");
    }

    public void DisplayLevel()
    {
        Console.WriteLine($"Current Level: {_level}, Total Points: {_totalPoints}");
    }
}